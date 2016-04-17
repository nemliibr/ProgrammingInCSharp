using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Defining the targets for a custom attribute
    class Listing2_66 : IExecuter
    {
        public void Execute(string[] args)
        {
            Test t = new Test();
            t.MyMethod("Hello World");
        }
    }

    [MyMultipleUsage("Test 1.1"), MyMultipleUsage("Test 1.2")]
    public class Test
    {
        [MyMethodAndParameter][CompleteCustom("MyCustomMethod")]
        public void MyMethod([MyMethodAndParameter] string message)
        {
            MethodBase method = typeof(Test).GetMethod("MyMethod");
            CompleteCustomAttribute attr = (CompleteCustomAttribute)method.GetCustomAttributes(typeof(CompleteCustomAttribute), true)[0];
            Console.WriteLine(attr.Description);
            
            Console.WriteLine(message);
        }
    }


    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter )]
    public class MyMethodAndParameterAttribute : Attribute { }

    //Listing 2.67 Setting the AllowMultiple parameter for a custom attribute
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class MyMultipleUsageAttribute : Attribute 
    {
        public string UsageString { get; set; }

        public MyMultipleUsageAttribute(string UsageString)
        {
            this.UsageString = UsageString;
        }
    }

    //Listing 2.68 Adding properties to a custom attribute
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    class CompleteCustomAttribute : Attribute
    {
        public CompleteCustomAttribute(string description)
        {
            Description = description;
        }
        public string Description { get; set; }
    }
}
