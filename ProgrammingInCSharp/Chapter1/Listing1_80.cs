using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    //Creating a lambda expression with multiple statements
    class Listing1_80 : IExecuter
    {
        public delegate int Calculate(int x, int y);

        public void Execute(string[] args)
        {
            Calculate calc = 
            (x, y) =>
            {
                Console.WriteLine("Adding numbers");
                return x + y;
            };

            int result = calc(3, 4);
            Console.WriteLine(result);
            // Displays 
            // Adding numbers 
        }
    }
}
