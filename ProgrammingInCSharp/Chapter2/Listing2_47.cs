using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_47 : IExecuter
    {
        public void Execute(string[] args)
        {
            Derived1 d = new Derived1();
            d.Run();
        }
    }

    class Base1
    {
        protected virtual void Execute()
        {
            Console.WriteLine("Hello from base!");
        }
    }
    class Derived1 : Base1
    {
        public void Run()
        {
            Execute();
        }

        protected override void Execute()
        {
            Log("Before executing");
            base.Execute();
            Log("After executing");
        }

        private void Log(string message) 
        {
            Console.WriteLine(message);
        }
    }
}
