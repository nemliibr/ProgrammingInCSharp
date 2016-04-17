using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    //Using TryParse
    class Listing3_5 : IExecuter
    {
        public void Execute(string[] args)
        {
            string value = "1";
            int result;
            bool success = int.TryParse(value, out result);

            if (success)
                Console.WriteLine("TryParse succeed it result is: " + result);
            else
                Console.WriteLine("TryParse failed");
        }
    }
}
