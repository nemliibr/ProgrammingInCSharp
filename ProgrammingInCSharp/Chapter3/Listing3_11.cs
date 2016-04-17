using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    class Listing3_11 : IExecuter
    {
        public void Execute(string[] args)
        {
            RegexOptions options = RegexOptions.None; 
            Regex regex = new Regex(@"[ ]{2,}", options); 
            string input = "1 2 3 4   5"; 
            string result = regex.Replace(input, " "); 
             
            Console.WriteLine(result); // Displays 1 2 3 4 5 
        }
    }
}
