using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_39 : IExecuter
    {
        private /*volatile*/ int _flag = 0;
        private /*volatile*/ int _value = 0;

        public void Execute(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Thread1);
            ThreadPool.QueueUserWorkItem(Thread2);
        }

        public void Thread1(Object obj)
        {
            _value = 5;
            _flag = 1;
        }

        public void Thread2(Object obj)
        {
            if (_flag == 1)
                Console.WriteLine(_value);
        }
    }
}
