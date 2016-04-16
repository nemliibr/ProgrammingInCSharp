using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Implementing IEnumerable<T> on a custom type
    class Listing2_56 : IExecuter
    {
        public void Execute(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Person("Alice", ""),
                new Person("Bob", ""),
                new Person("Charlie",""),
                new Person("Dave", "")
            };

            People people = new People(persons);
            IEnumerator enumerator = people.GetEnumerator();
            while(enumerator.MoveNext())
                Console.WriteLine(enumerator.Current.ToString());
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    class People : IEnumerable<Person>
    {
        Person[] people;

        public People(Person[] people)
        {
            this.people = people;
        }
        
        public IEnumerator<Person> GetEnumerator()
        {
            for (int index = 0; index < people.Length; index++)
            {
                yield return people[index];
            }
        }

        //Explicit implemting of interface IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
