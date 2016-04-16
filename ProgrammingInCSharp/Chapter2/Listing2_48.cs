using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Hiding a method with the new keyword
    class Listing2_48 : IExecuter
    {
        public void Execute(string[] args)
        {
            Base2 b = new Base2();
            b.Execute();
            b = new Derived2();
            b.Execute();
            
            Derived2 d = new Derived2();
            d.Execute();
        }
    }

    class Base2
    {
        public void Execute() { Console.WriteLine("Base.Execute"); }
    }

    class Derived2 : Base2
    {
        public new void Execute() { Console.WriteLine("Derived.Execute"); }
    }
}
