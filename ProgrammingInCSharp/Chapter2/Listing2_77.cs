using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Creating a Func type with a lambda
    class Listing2_77 : IExecuter
    {
        public void Execute(string[] args)
        {
            Func<int, int, int> addFunc = (x, y) => x + y;
            Action<int, int> multFunc = (x, y) => Console.WriteLine(x * y);
            
            Console.WriteLine(addFunc(2, 3));
            multFunc(2, 3);
        }
    }
}
