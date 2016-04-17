using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Executing a method through reflection
    class Listing2_73 : IExecuter
    {
        public void Execute(string[] args)
        {
            int i = 42; 
            MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo",  new Type[] { typeof(int) }); 
            int result = (int)compareToMethod.Invoke(i, new object[] { 41 });
            Console.WriteLine(result);
        }
    }
}
