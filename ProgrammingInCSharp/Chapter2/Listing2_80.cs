using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    // Not closing a file will throw an error
    class Listing2_80 : IExecuter
    {
        public void Execute(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat"); 
            stream.Write("some data"); 
            File.Delete("temp.dat"); // Throws an IOException because the file is already open.
        }
    }
}
