using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_72 : IExecuter
    {
        public void Execute(string[] args)
        {
            ClassWithFields cwf = new ClassWithFields();
            DumpObject(cwf);
        }

        static void DumpObject(object obj)
        {
            //gets all fields that are public og non public
            FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.FieldType.Name + " " + field.Name + ": " + field.GetValue(obj));
            }
        }
    }

    class ClassWithFields
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        static int e;

        public ClassWithFields()
        {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
        }
    }
}
