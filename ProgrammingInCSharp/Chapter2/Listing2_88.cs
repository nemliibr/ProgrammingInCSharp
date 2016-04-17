using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_88 : IExecuter
    {
        public void Execute(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            StringBuilder sb = new StringBuilder(string.Empty);
            for (int i = 0; i < 10000; i++)
            {
                sb.Append("x");
            }
            Console.WriteLine("stringbuilder: " + sw.Elapsed);

            sw.Reset();
            string a = new String('x', 10000);
            Console.WriteLine("string constructor: " + sw.Elapsed);
            sw.Stop();
        }
    }
}
