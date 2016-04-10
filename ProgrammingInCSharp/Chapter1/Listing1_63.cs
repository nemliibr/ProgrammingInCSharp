using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_63 : IExecuter
    {
        public void Execute(string[] args)
        {
            int i = 1;
            switch (i)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    goto case 2;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
            }
        }
    }
}
