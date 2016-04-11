using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_91 : IExecuter
    {
        public void Execute(string[] args)
        {
            string s = Console.ReadLine(); 
            try 
            { 
                int i = int.Parse(s); 
            } 
            catch (ArgumentNullException) 
            { 
                Console.WriteLine("You need to enter a value"); 
            } 
            catch (FormatException)
            { 
                Console.WriteLine("{0} is not a valid number. Please try again", s); 
            } 
            finally 
            {
                Console.WriteLine("Program complete."); 
            } 
        }
    }
}
