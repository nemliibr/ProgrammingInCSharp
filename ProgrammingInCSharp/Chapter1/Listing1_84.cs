using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_84 : IExecuter
    {
        public void Execute(string[] args)
        {
            CreateAndRaise();
        }

        public void CreateAndRaise()
        {
            Pub p = new Pub();

            p.OnChangeEventWithArgs += (sender, e)
                => Console.WriteLine("Event raised: {0}", e.Value);

            p.RaiseEventWithArgs();
        }
    }
}
