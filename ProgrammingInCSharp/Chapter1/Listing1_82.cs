using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_82 : IExecuter
    {
        public void Execute(string[] args)
        {
            CreateAndRaise();
        }

        public void CreateAndRaise() 
        { 
            Pub p = new Pub(); 
            p.OnChangeAction += () => Console.WriteLine("Event raised to method 1");
            p.OnChangeAction += () => Console.WriteLine("Event raised to method 2"); 
            p.RaiseAction(); 
        }
    }

    public class Pub 
    { 
        public Action OnChangeAction { get; set; }
        public event EventHandler OnChangeEvent = delegate { };
        public event EventHandler<MyArgs> OnChangeEventWithArgs = delegate { };
        
        public void RaiseAction() 
        { 
            if (OnChangeAction != null) 
            { 
                OnChangeAction(); 
            }       
        }

        public void RaiseEvent()
        {
            OnChangeEvent(this, EventArgs.Empty);
        }
    
        public void RaiseEventWithArgs()
        {
            OnChangeEventWithArgs(this, new MyArgs(42));
        }
    }

    public class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }
}
