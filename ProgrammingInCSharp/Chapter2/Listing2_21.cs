using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Implicitly converting an object to a base type
    class Listing2_21 : IExecuter
    {
        public void Execute(string[] args)
        {
            HttpClient client = new HttpClient();
            object o = client;
            IDisposable d = client;
            //d.Dispose();
        }
    }
}
