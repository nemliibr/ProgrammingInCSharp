using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    //Throwing an ArgumentNullException
    class Listing1_94 : IExecuter
    {
        public void Execute(string[] args)
        {
            OpenAndParse(null);
        }

        public string OpenAndParse(string fileName) 
        { 
            if (string.IsNullOrWhiteSpace(fileName)) 
                throw new ArgumentNullException("fileName", "Filename is required"); 
 
            return File.Exists(fileName) ? File.ReadAllText(fileName) : null;
        }
    }
}
