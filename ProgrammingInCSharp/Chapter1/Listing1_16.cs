using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_16 : IExecuter
    {
        public void Execute(string[] args)
        {
            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
            });

            // Perform three tasks in parallel on the source array
            Parallel.Invoke(
                BasicAction,	// Param #0 - invoke method method
                () =>			// Param #1 - lambda expression
                {
                    Console.WriteLine("Method=beta, Thread={0}", Thread.CurrentThread.ManagedThreadId);
                },
                delegate()		// Param #2 - in-line delegate
                {
                    Console.WriteLine("Method=gamma, Thread={0}", Thread.CurrentThread.ManagedThreadId);
                }
            ); 
        }

        private void BasicAction()
        {
            Console.WriteLine("Method=alpha, Thread={0}", Thread.CurrentThread.ManagedThreadId);
        }

    }
}
