using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_72 : IExecuter
    {
        public void Execute(string[] args)
        {
            CannotChangeForeachIterationVariable();
        }

        void CannotChangeForeachIterationVariable()
        {
            var people = new List<Person> 
            { 
                new Person() { FirstName = "John", LastName = "Doe"}, 
                new Person() { FirstName = "Jane", LastName = "Doe"}, 
            };

            foreach (Person p in people)
            {
                p.LastName = "Changed"; // This is allowed 
                //p = new Person(); // This gives a compile error 
                Console.WriteLine(p.ToString());
            }
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
             
    }
}

