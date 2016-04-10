using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    //Using the event keyword
    class Listing1_83 : IExecuter
    {
        public event Action OnChange = delegate { };

        public void Raise()
        {
            OnChange();
        }

        public void Execute(string[] args)
        {
            //Those two lines are not needed!
            OnChange += () => Console.WriteLine("Hello from subscriber 1");
            OnChange += () => Console.WriteLine("Hello from subscriber 2");
            Raise();
        }
    }
}
