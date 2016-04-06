using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_31 : IExecuter
    {
        public void Execute(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Task.Run(() =>
            {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });

            Task.Run(() =>
            {
                //the ConcurrentBag doesn't have GetConsumingEnumerable() as BlockingCollection have
                foreach (int i in bag)
                    Console.WriteLine(i);
            }).Wait();
        }
    }
}
