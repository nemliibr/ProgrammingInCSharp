using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    //Manually raising events with exception handling
    class Listing1_87 : IExecuter
    {
        public event EventHandler OnChange = delegate { };
        public void Raise()
        {
            var exceptions = new List<Exception>();

            foreach (Delegate handler in OnChange.GetInvocationList())
            {
                try
                {
                    handler.DynamicInvoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }

            if (exceptions.Any())
            {
                throw new AggregateException(exceptions);
            }
        }

        public void CreateAndRaise()
        {
            OnChange += (sender, e)
                => Console.WriteLine("Subscriber 1 called");

            OnChange += (sender, e)
                => { throw new Exception(); };

            OnChange += (sender, e)
                => Console.WriteLine("Subscriber 3 called");

            try
            {
                Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Number of inner exceptions: " + ex.InnerExceptions.Count);
            }
        }

        public void Execute(string[] args)
        {
            CreateAndRaise();
        }
    }
}
