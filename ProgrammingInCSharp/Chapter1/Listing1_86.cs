using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    //Exception when raising an event
    class Listing1_86 : IExecuter
    {
        public void Execute(string[] args)
        {
            CreateAndRaise();
        }

        public void CreateAndRaise()
        {
            Pub p = new Pub();

            p.OnChangeEvent += (sender, e)
                => Console.WriteLine("Subscriber 1 called");

            p.OnChangeEvent += (sender, e)
                => { throw new Exception(); };

            p.OnChangeEvent += (sender, e)
                => Console.WriteLine("Subscriber 3 called");

            p.RaiseEvent();
        }
    }
}
