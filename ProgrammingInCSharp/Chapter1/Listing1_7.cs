using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_7 : IExecuter
    {
        public void Execute(string[] args)
        {
            //Note: Threadpool threads execute as "background thread"
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });

            //alternatives for using threadpool
            ThreadPool.QueueUserWorkItem(ThreadProc);
            ThreadPool.QueueUserWorkItem(ThreadProc, "This is my message");
        }

        //Called by a tread from the Threadpool
        private void ThreadProc(Object stateInfo)
        {
            String message = "Hello from the thread pool.";
            if (stateInfo is string)
                message = (string)stateInfo;

            Console.WriteLine(message);
        }
    }
}
