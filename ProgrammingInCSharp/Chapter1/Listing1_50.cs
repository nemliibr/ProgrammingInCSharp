using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_50 : IExecuter
    {
        public void Execute(string[] args)
        {
            Process(null);
            Process("appelsin");
            Process("vandmelon");

        }

        public void Process(string input) 
        { 
            bool result = (input != null) && (input.StartsWith("v"));
            Console.WriteLine(result);
        }
    }
}
