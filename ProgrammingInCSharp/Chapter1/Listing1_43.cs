using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_43 : IExecuter
    {
        public void Execute(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(); 
            CancellationToken token = cancellationTokenSource.Token;
            
            Task task = Task.Run(() => 
            { 
                while (!token.IsCancellationRequested) 
                {
                    Console.Write("*"); 
                    Thread.Sleep(1000); 
                } 
 
                token.ThrowIfCancellationRequested(); 
  
            }, token); 
 
            try 
            {
                Console.WriteLine("Press enter to stop the task"); 
                Console.ReadLine(); 
 
                cancellationTokenSource.Cancel(); 
                task.Wait(); 
            }  
            catch (AggregateException e) 
            { 
                Console.WriteLine(e.InnerExceptions[0].Message); 
            } 
        }
    }
}
