using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Creating a custom struct
    class Listing2_2 : IExecuter
    {
        public void Execute(string[] args)
        {
            PointStruct p1 = new PointStruct(2, 2);
            PointClass p2 = new PointClass(2, 2);
            
            Console.WriteLine("Before:");
            Console.WriteLine("p1: " + p1.ToString());
            Console.WriteLine("p2: " + p2.ToString());
            Change(p1); //should not change the values for p1!
            Change(p2);
            Console.WriteLine("After:");
            Console.WriteLine("p1: " + p1.ToString());
            Console.WriteLine("p2: " + p2.ToString());
        }

        private void Change(PointStruct p)
        {
            p.x += 3;
            p.y += 3;
        }

        private void Change(PointClass p)
        {
            p.x += 3;
            p.y += 3;
        }
    }

    //value type
    public struct PointStruct
    {
        public int x, y;

        public PointStruct(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public override string ToString()
        {
            return x +", " +y;
        }
    }

    //reference type;
    public class PointClass
    {
        public int x, y;

        public PointClass(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public override string ToString()
        {
            return x + ", " + y;
        }
    }
}
