using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_5 : IExecuter
    {
        [ThreadStatic]
        //the static modifier is important, otherwise it won't work as expected
        public static int _field; 
        
        public void Execute(string[] args)
        {
            new Thread(() => 
               {  
                    for(int x = 0; x < 10; x++) 
                    { 
                        _field++; 
                        Console.WriteLine("Thread A: {0}", _field); 
                    } 
                }).Start(); 

            new Thread(() => 
                {  for(int x = 0; x < 10; x++) 
                    { 
                        _field++; 
                        Console.WriteLine("Thread B: {0}", _field); 
                    } 
                }).Start(); 
        } 
    } 
} 
