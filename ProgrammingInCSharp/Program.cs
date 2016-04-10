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
            //code = new Listing1_16();
            //code = new Listing1_17();
            //code = new Listing1_18();
            //code = new Listing1_19();
            //code = new Listing1_20();
            //code = new Listing1_21();
            //code = new Listing1_22();
            //code = new Listing1_23();
            //code = new Listing1_24();
            //code = new Listing1_25();
            //code = new Listing1_26();
            //code = new Listing1_27();
            //code = new Listing1_28();
            //code = new Listing1_29();
            //code = new Listing1_30();
            //code = new Listing1_31();
            //code = new Listing1_32();
            //code = new Listing1_33();
            //code = new Listing1_34();
            //code = new Listing1_35();
            //code = new Listing1_36();
            //code = new Listing1_37();
            //code = new Listing1_39();
            //code = new Listing1_40();
            //code = new Listing1_41();
            //code = new Listing1_42();
            //code = new Listing1_43();
            //code = new Listing1_44();
            //code = new Listing1_45();
            //code = new Listing1_48();
            //code = new Listing1_50();
            //code = new Listing1_54();
            //code = new Listing1_58();
            //code = new Listing1_59();
            //code = new Listing1_63();
            //code = new Listing1_65();
            //code = new Listing1_66();
            //code = new Listing1_67();
            //code = new Listing1_68();
            //code = new Listing1_72();
            //code = new Listing1_74();
            //code = new Listing1_75();
            //code = new Listing1_76();
            //code = new Listing1_77();
            //code = new Listing1_78();
            //code = new Listing1_79();
            //code = new Listing1_80();
            //code = new Listing1_81();
            //code = new Listing1_82();
            //code = new Listing1_83();
            //code = new Listing1_84();
            //code = new Listing1_85();
            //code = new Listing1_86();
            //code = new Listing1_87();
                                    
            code.Execute(args);
            Console.WriteLine("Press enter to end the application");
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
