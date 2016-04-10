using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_79 : IExecuter
    {
        public delegate int Calculate(int x, int y);

        public void Execute(string[] args)
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4)); // Displays 7
            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4)); // Displays 12
        }
    }
}
