using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    //Covariance with delegates
    class Listing1_77 : IExecuter
    {
        public delegate TextWriter CovarianceDel();

        public StreamWriter MethodStream() { Console.WriteLine("StreamWriter"); return null; }
        public StringWriter MethodString() { Console.WriteLine("StringWriter");  return null; }

        public void Execute(string[] args)
        {
            CovarianceDel del;
            del = MethodStream;
            del += MethodString;
            del();
        }
    }
}
