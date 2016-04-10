using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_76 : IExecuter
    {
        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public delegate void Del();

        public void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();
        }

        public void Execute(string[] args)
        {
            Multicast();
        }
    }
}
