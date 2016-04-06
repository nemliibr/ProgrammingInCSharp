using ProgrammingInCSharp.Interfaces;
using System;
using System.Threading;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_6 : IExecuter
    {
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
            });

        public void Execute(string[] args)
        {
            new Thread(() =>
               {
                   for (int x = 0; x < _field.Value; x++)
                   {
                       Console.WriteLine("Thread A: {0}", x);
                   }
               }).Start();

            new Thread(() =>
                {
                    for (int x = 0; x < _field.Value; x++)
                    {
                        Console.WriteLine("Thread B: {0}", x);
                    }
                }).Start();
        }
    }
}
