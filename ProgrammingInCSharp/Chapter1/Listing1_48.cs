using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_48 : IExecuter
    {
        public void Execute(string[] args)
        {
            OrShortCircuit();
        }

        public void OrShortCircuit()
        {
            bool x = true;
            bool result = x || GetY();
        }

        private bool GetY()
        {
            Console.WriteLine("This method doesn’t get called");
            return true;
        }
    }
}
