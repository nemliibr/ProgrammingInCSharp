using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_61 : IExecuter
    {
        public void Execute(string[] args)
        {
            if (Attribute.IsDefined(typeof(Person1), typeof(SerializableAttribute))) 
                Console.WriteLine("Person is serializable");
            else
                Console.WriteLine("Person is not serializable");

            //Listing 2.62
            ConditionalAttribute conditionalAttribute =
                (ConditionalAttribute)Attribute.GetCustomAttributes(typeof(Person1).GetMethod("MyMethod"), typeof(ConditionalAttribute)).First();
            Console.WriteLine(conditionalAttribute.ConditionString);

            //Alternative to listing 2.62
            MethodBase method = typeof(Person1).GetMethod("MyMethod");
            ConditionalAttribute attr = (ConditionalAttribute)method.GetCustomAttributes(typeof(ConditionalAttribute), true)[0];
            Console.WriteLine(attr.ConditionString);
        }
    }

    [Serializable]
    class Person1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Conditional("CONDITION1"), Conditional("CONDITION2")] 
        public void MyMethod(){ }
    }
}
