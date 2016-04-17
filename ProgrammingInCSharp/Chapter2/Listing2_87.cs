using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_87 : IExecuter
    {
        public void Execute(string[] args)
        {
            StringBuilder sb = new StringBuilder("A initial value");
            sb[0] = 'B';
            Console.WriteLine(sb.ToString());
        }
    }
}
