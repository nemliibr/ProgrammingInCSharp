using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    //Using Convert with a null value
    class Listing3_7 : IExecuter
    {
        public void Execute(string[] args)
        {
            //converting null to any type returns default value
            int i = Convert.ToInt32(null);
            Console.WriteLine(i); // Displays 0
        }
    }
}
