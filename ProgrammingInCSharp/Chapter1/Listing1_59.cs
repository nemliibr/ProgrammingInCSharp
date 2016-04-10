using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_59 : IExecuter
    {
        public void Execute(string[] args)
        {
            int? x = null;
            int? z = null;
            int y = x ??
                    z ??
                    -1;

            Console.WriteLine("x: " + x);
            Console.WriteLine("z: " + z);
            Console.WriteLine("y: " + y);
        }
    }
}
