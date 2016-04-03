using ProgrammingInCSharp.Chapter1;
using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //if you want to run a list of listings at once
            //ExecuteListings(args, new Listing1_1(), new Listing1_2() ...);

            IExecuter code = null;

            //chapter 1
            code = new Listing1_1();
            //code = new Listing1_2();
            //code = new Listing1_3();
            //code = new Listing1_4();
            //code = new Listing1_5();
            //code = new Listing1_6();
            //code = new Listing1_7();
            //code = new Listing1_8();
            //code = new Listing1_9();
            //code = new Listing1_10();
            //code = new Listing1_11();
            //code = new Listing1_12();
            //code = new Listing1_13();
            //code = new Listing1_14();
            //code = new Listing1_15();

            code.Execute(args);
            Console.ReadLine();
        }

        //executes a list of listings one by one
        private static void ExecuteListings(string[] args, params IExecuter[] listings)
        {
            foreach (IExecuter listing in listings)
            {
                listing.Execute(args);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
