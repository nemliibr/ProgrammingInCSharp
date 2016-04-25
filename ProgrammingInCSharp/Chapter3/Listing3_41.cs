using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    // Call a method only in a debug build
    class Listing3_41 : IExecuter
    {
        public void Execute(string[] args)
        {
            SomeMethod();
        }

        public void SomeMethod()
        {
#if DEBUG
            Log1("Step1");
#endif
            Log2("Step2");
        }

        private void Log1(string message)
        {
            Console.WriteLine(message);
        }

        //LISTING 3-42  Applying the ConditionalAttribute
        [Conditional("DEBUG")]
        private void Log2(string message)
        {
            Console.WriteLine(message);
        }
    }
}
