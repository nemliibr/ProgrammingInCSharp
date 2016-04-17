using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    //LISTING 3-4  Using Parse
    class Listing3_4 : IExecuter
    {
        public void Execute(string[] args)
        {
            string value = "true"; 
            bool b = bool.Parse(value); 
            Console.WriteLine(b); // displays True
        }
    }
}
