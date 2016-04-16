using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    // Chaining constructors
    class Listing2_12 : IExecuter
    {
        public void Execute(string[] args)
        {
            ConstructorChaining c1 = new ConstructorChaining("A");
            ConstructorChaining c2 = new ConstructorChaining();
            ConstructorChaining c3 = new ConstructorChaining(7);
        }
    }

    class ConstructorChaining
    {
        private int _p;
        
        public ConstructorChaining(object o) : this() 
        {
            //this() will be called before this WriteLine
            Console.WriteLine("Constructor with object as argument has been called");
        }

        public ConstructorChaining() : this(3)
        {
            //this(3) will be called before this WriteLine
            Console.WriteLine("Default constructor has been called");
        }

        public ConstructorChaining(int p)
        {
            Console.WriteLine("ConstructorChaining with int as argument has been called");
            this._p = p;
        }
    } 
}
