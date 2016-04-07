using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_35 : IExecuter
    {
        public void Execute(string[] args)
        {
            int n = 0; 
  
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    n++;
            });

            for (int i = 0; i < 1000000; i++)
                n--;

            up.Wait();
            Console.WriteLine(n); 
        }
    }
}
