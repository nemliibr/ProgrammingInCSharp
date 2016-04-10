using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_58 : IExecuter
    {
        public void Execute(string[] args)
        {
            int? x = null;
            int y = x ?? -1;

            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
        }
    }
}
