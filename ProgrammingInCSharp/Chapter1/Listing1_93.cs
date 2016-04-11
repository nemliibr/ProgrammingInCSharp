using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_93 : IExecuter
    {
        public void Execute(string[] args)
        {
            try 
            { 
                int i = ReadAndParse(); 
                Console.WriteLine("Parsed: {0}", i); 
            } 
            catch (FormatException e) 
            { 
                Console.WriteLine("Message: {0}",e.Message); 
                Console.WriteLine("StackTrace: {0}", e.StackTrace); 
                Console.WriteLine("HelpLink: {0}", e.HelpLink); 
                Console.WriteLine("InnerException: {0}", e.InnerException); 
                Console.WriteLine("TargetSite: {0}", e.TargetSite); 
                Console.WriteLine("Source: {0}", e.Source); 
            }
        } 
  
        private int ReadAndParse() 
        { 
            string s = Console.ReadLine(); 
            int i = int.Parse(s); 
            return i; 
        }
    }
}
