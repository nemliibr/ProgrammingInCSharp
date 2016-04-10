using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_74 : IExecuter
    {
        public void Execute(string[] args)
        {
            int x = 3;
            if (x == 3) goto customLabel;
            x++;

        customLabel:
            Console.WriteLine(x);
            // Displays 3
        }
    }
}
