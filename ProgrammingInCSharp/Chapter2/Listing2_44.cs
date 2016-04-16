using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Instantiating a concrete type that implements an interface
    class Listing2_44 : IExecuter
    {
        public void Execute(string[] args)
        {
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();

            dog.Move();
            //dog.Bark();  <- not possible through the interface
            Dog d = (Dog)dog;
            d.Move();
            d.Bark();
            MoveAnimimal(dog);
            MoveAnimimal(d);
            
            Cat c = new Cat();
            //c.Move(); 
            c.Meow();
            MoveAnimimal(c);
            
        }

        void MoveAnimimal(IAnimal animal)
        {
            animal.Move();
        }
    }

    interface IAnimal
    {
        void Move();
    }

    class Dog : IAnimal
    {
        public void Move() { Console.WriteLine("Dog move"); }
        public void Bark() { Console.WriteLine("Dog bark");}
    }

    class Cat : IAnimal
    {
        void IAnimal.Move() { Console.WriteLine("Cat move"); }
        public void Meow() { Console.WriteLine("Cat meow");}
    }
}
