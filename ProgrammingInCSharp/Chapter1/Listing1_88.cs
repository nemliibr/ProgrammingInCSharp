using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    //Parsing an invalid number
    class Listing1_88 : IExecuter
    {
        public void Execute(string[] args)
        {
            string s = "NaN"; 
            int i = int.Parse(s); 
        }
    }
}
