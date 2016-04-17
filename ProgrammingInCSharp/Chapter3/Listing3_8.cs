using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    class Listing3_8 : IExecuter
    {
        public void Execute(string[] args)
        {
            double d = 23.15;
            int i = Convert.ToInt32(d);
            Console.WriteLine(i); // Displays 23
        }
    }
}
