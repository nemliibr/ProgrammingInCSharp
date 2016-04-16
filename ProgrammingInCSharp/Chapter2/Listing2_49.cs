using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_49 : IExecuter
    {
        public void Execute(string[] args)
        {
            Base3 b = new Derived3();
            b.AbstractMethod();
            b.MethodWithImplementation();
        }
    }

    abstract class Base3
    {
        public virtual void MethodWithImplementation() 
        {
            Console.WriteLine("base.MethodWithImplementation");
        }

        public abstract void AbstractMethod();
    }
    class Derived3 : Base3
    {
        public override void AbstractMethod() 
        {
            Console.WriteLine("derived.AbstractMethod");
        }

        public override void MethodWithImplementation()
        {
            Console.WriteLine("derived.MethodWithImplementation");
            base.MethodWithImplementation();
        }

    }
}
