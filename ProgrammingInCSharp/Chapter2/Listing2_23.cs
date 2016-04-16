using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Explicitly casting a base type to a derived type
    class Listing2_23 : IExecuter
    {
        public void Execute(string[] args)
        {
            Object stream = new MemoryStream();
            MemoryStream memoryStream = (MemoryStream)stream;
        }
    }
}
