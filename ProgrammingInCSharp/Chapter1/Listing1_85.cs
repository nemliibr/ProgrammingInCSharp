using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    //Custom event accessor
    class Listing1_85 : IExecuter
    {
        public class MyArgs : EventArgs
        {
            public MyArgs(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
        }

        private event EventHandler<MyArgs> onChange = delegate { };
        public event EventHandler<MyArgs> OnChange
        {
            add
            {
                lock (onChange)
                {
                    onChange += value;
                    // Do something here.
                    Console.WriteLine("Event handler attached: " + value.Method.Name);
                }
            }
            remove
            {
                lock (onChange)
                {
                    onChange -= value;
                    //Do something extra here.
                    Console.WriteLine("Event handler detached: " + value.Method.Name);
                }
            }
        }

        public void Raise()
        {
            onChange(this, new MyArgs(42));
        } 

        public void Execute(string[] args)
        {
            OnChange += (sender, e) => Console.WriteLine("Subscriber 1: " + e.Value);
            OnChange += (sender, e) => Console.WriteLine("Subscriber 2: " + e.Value);
            OnChange += OnChanged;
            Raise();

            OnChange -= OnChanged;
            Raise();
        }

        public void OnChanged(object sender, MyArgs e)
        {
            Console.WriteLine("Subscriber 3: " + e.Value);
        }
    }
}
