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
            //code = new Listing1_1();
            code = new Listing1_2();


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
