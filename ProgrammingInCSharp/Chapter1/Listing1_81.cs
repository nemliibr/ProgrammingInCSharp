using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    //Using the Action delegate
    class Listing1_81 : IExecuter
    {
        public delegate int Calculate(int x, int y);

        public void Execute(string[] args)
        {
            Action<int, int> calc = (x, y) =>
            {
                Console.WriteLine(x + y);
            };

            calc(3, 4); // Displays 7
        }
    }
}
