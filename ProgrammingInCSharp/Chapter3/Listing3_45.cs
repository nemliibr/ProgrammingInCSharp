using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    class Listing3_45 : IExecuter
    {
        public void Execute(string[] args)
        {
            Debug.WriteLine("Starting application"); 
            Debug.Indent(); 
            int i = 1 + 2; 
            Debug.Assert(i == 3); 
            Debug.WriteLineIf(i > 0, "i is greater than 0");
        }
    }
}
