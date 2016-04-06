using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_27 : IExecuter
    {
        public void Execute(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            try 
            {
                var parallelResult = numbers.AsParallel().Where(i => IsEven(i)); 
                parallelResult.ForAll(e => Console.WriteLine(e)); 
            } 
            catch (AggregateException e) 
            { 
                Console.WriteLine("There where {0} exceptions", e.InnerExceptions.Count); 
            } 
        } 
  
        public static bool IsEven(int i) 
        { 
            if (i % 10 == 0) 
                throw new ArgumentException("i"); 
            return i % 2 == 0; 
        }
    }
}
