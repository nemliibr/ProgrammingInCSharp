using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_26 : IExecuter
    {
        public void Execute(string[] args)
        {
            int value = Convert.ToInt32("42"); 
            value = int.Parse("42"); 
            bool success = int.TryParse("42", out value);
            Console.WriteLine(success);

            MyClass m;
            MyClass.TryParse("5,6", out m);
            Console.WriteLine(m.ToString());
            
        }
    }

    class MyClass
    {
        public int x { get; set; }
        public int y { get; set; }

        public override string ToString()
        {
            return x + ", " + y;
        }

        public static bool TryParse(string s, out MyClass myClass)
        {
            string[] split = s.Split(',');
            int x = 0;
            int y = 0;
            int.TryParse(split[0], out x);
            int.TryParse(split[1], out y);

            myClass = new MyClass();
            myClass.x = x;
            myClass.y = y;
            return true;
        }
    }
}
