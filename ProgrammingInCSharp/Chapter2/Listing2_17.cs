using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Overriding a virtual method
    class Listing2_17 : IExecuter
    {
        public void Execute(string[] args)
        {
            Base parent = new Base();
            Derived child = new Derived();
            
            object childAsObject = child;
            Base childAsParent1 = (Derived)childAsObject; //requires explicit casting
            Base childAsParent2 = child; //implicit casting is ok

            //InvalidCastException - cannot go from base to derived!
            //Derived parentAsChild = (Derived)parent; 
            //Console.WriteLine(parentAsChild.MyMethod());

            Console.WriteLine(parent.MyMethod());
            Console.WriteLine(child.MyMethod());
            Console.WriteLine(childAsParent1.MyMethod());
            Console.WriteLine(childAsParent2.MyMethod());
        }
    }

    class Base
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }

    class Derived : Base
    {
        public override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }
}
