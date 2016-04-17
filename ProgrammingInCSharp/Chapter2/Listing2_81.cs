using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Forcing a garbage collection
    class Listing2_81 : IExecuter
    {
        public void Execute(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat"); 
            stream.Write("some data"); 
            GC.Collect(); 
            GC.WaitForPendingFinalizers();
            stream.Flush();
            stream.Close();
            File.Delete("temp.dat");
        }
    }
}
