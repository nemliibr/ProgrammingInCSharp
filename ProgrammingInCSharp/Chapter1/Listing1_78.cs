using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    //Contravariance with delegates
    class Listing1_78 : IExecuter
    {
        public delegate void ContravarianceDel(StreamWriter tw);
        
        void DoSomething(TextWriter tw) 
        {
            Console.WriteLine("DoSomething() has been called");
            tw.WriteLine("Hello from DoSomething()");
            tw.Flush();
            tw.Close();
        }

        public void Execute(string[] args)
        {
            ContravarianceDel del = DoSomething;
            StreamWriter sw = File.CreateText("newFile.txt");
            del(sw);
        }
    }
}
