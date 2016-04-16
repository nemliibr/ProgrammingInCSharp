using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Using named and optional arguments
    class Listing2_7 : IExecuter
    {

        public void Execute(string[] args)
        {
            MyMethod(1, thirdArgument: true);
            MyMethod(2, thirdArgument: "Hello world!");
            //MyMethod(3); <- ambiguous method call
            //MyMethod(4, "Hello world!"); <- ambiguous method call
        }

        void MyMethod(int firstArgument, string secondArgument = "default value",  bool thirdArgument = false) 
        {
            Console.WriteLine("firstArgument: " + firstArgument);
            Console.WriteLine("secondArgument: " + secondArgument);
            Console.WriteLine("thirdArgument: " + thirdArgument);
        }

        void MyMethod(int firstArgument, string secondArgument = "default value 1", string thirdArgument = "default value 2")
        {
            Console.WriteLine("firstArgument: " + firstArgument);
            Console.WriteLine("secondArgument: " + secondArgument);
            Console.WriteLine("thirdArgument: " + thirdArgument);
        }
    }
}
