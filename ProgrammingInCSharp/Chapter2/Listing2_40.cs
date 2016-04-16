using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_40 : IExecuter
    {
        public void Execute(string[] args)
        {
            MoveableOject mo = new MoveableOject();
            ((ILeft)mo).Move();
            ((IRight)mo).Move();
        }
    }

    interface ILeft
    {
        void Move();
    }
    interface IRight
    {
        void Move();
    }
    
    class MoveableOject : ILeft, IRight
    {
        void ILeft.Move()
        {
            Console.WriteLine("ILeft move");
        }
        
        void IRight.Move()
        {
            Console.WriteLine("IRight move");
        }
    }
}
