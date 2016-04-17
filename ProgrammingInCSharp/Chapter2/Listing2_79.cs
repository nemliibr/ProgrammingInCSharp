using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //start this program without debugging (Ctrl+F5)
    class Listing2_79 : IExecuter
    {
        public void Execute(string[] args)
        {
            SomeType st = new SomeType();
        }
    }

    public class SomeType
    {
        ~SomeType()
        {
            Console.WriteLine("Finalizer has been called");
        }
    }
}
