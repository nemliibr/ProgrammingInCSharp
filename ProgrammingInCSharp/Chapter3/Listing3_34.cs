using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    class Listing3_34 : IExecuter
    {
        public void Execute(string[] args)
        {
            DebugDirective();
        }

        public void DebugDirective()
        {
#if DEBUG
            Console.WriteLine("Debug mode");
#else 
            Console.WriteLine("Not debug"); 
#endif
        }
    }
}
