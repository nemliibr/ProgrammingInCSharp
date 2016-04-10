using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_54 : IExecuter
    {
        public void Execute(string[] args)
        {
            bool b = true;
            if (b)
            {
                int r = 42;
                b = false;
            }
            // r is not accessible 
            // b is now false
            
            //int r = 32; //<- why does this give an error, it's out of scope?
            //Console.WriteLine(r);
            //Console.WriteLine(b);
            
        }
    }
}
