using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_14 : IExecuter
    {
        public void Execute(string[] args)
        {
            MyClass<ClassA> a = new MyClass<ClassA>();
            a.MyProperty.x = 3;
            a.MyProperty.y = 2;

            MyClass<ClassB> b = new MyClass<ClassB>();
            b.MyProperty.x = 3;
            b.MyProperty.y = 5;

            Console.WriteLine(a.MyProperty.ToString());
            Console.WriteLine(b.ToString());

            MyClassWithInterface<ClassAA> aa = new MyClassWithInterface<ClassAA>();
            Console.WriteLine(aa.ToString());
            MyClassWithInterface<ClassBB> bb = new MyClassWithInterface<ClassBB>();
            Console.WriteLine(bb.ToString());

            MyGenericMethod<int>();
            MyGenericMethod<ClassAA>();
        }

        //Listing 2.15
        public void MyGenericMethod<T>()
        {
            T defaultValue = default(T);
            if (defaultValue != null)
                Console.WriteLine("default value for " + defaultValue.GetType().Name + " : " + defaultValue.ToString());
            else
                Console.WriteLine("default value for " + typeof(T).Name + " : null");
        }
    }

    class MyClass<T> where T : class, new()
    {
        public T MyProperty { get; set; }

        public MyClass()
        {
            MyProperty = new T();
        }
    }
    
    class ClassA
    {
        public int x { get; set; }
        public int y { get; set; }

        public override string ToString()
        {
            return x + ", " + y;
        }
    }

    class ClassB
    {
        public int x { get { return 1; } set { return; } }
        public int y { get { return 1; } set { return; } }

        public override string ToString()
        {
            return x + ", " + y;
        }
    }

    class MyClassWithInterface<T> where T : IMyInterface, new()
    {
        public T MyProperty { get; set; }

        public MyClassWithInterface()
        {
            MyProperty = new T();
        }

        public override string ToString()
        {
            return MyProperty.x + ", " + MyProperty.y;
        }
    }

    interface IMyInterface
    {
        int x { get; set; }
        int y { get; set; }
    }

    class ClassAA : IMyInterface
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    class ClassBB : IMyInterface
    {
        public int x { get { return 1; } set { return; } }
        public int y { get { return 1; } set { return; } }
    }
}
