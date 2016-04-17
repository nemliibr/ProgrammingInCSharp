using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    // Using WeakReference
    class Listing2_85 : IExecuter
    {
        public void Execute(string[] args)
        {
            Run();
        }

        WeakReference data;

        public void Run()
        {
            object result = GetData();
            //GC.Collect(); Uncommenting this line will make data.Target null 
            result = GetData();
        }

        private object GetData()
        {
            if (data == null)
            {
                data = new WeakReference(LoadLargeList());
            }

            if (data.Target == null)
            {
                data.Target = LoadLargeList();
            }
            return data.Target;
        }

        private object LoadLargeList()
        {
            var list = Enumerable.Range(0, 100000).ToList();
            return list;
        }
    }
}
