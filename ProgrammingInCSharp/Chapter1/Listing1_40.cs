using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_40 : IExecuter
    {
        public void Execute(string[] args)
        {
            int n = 0;

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    Interlocked.Increment(ref n);
            });

            for (int i = 0; i < 1000000; i++)
                Interlocked.Decrement(ref n);

            //Other methods good to know:

            //Interlocked.CompareExchange(ref n, newValue, expectedValue);
            //checks to see whether the expected value is there; if it is, it replaces it with newValue.
            
            //Interlocked.Exchange(ref n, newValue);
            //retrieves the current value and immediately sets it to the new value in the same operation.

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
