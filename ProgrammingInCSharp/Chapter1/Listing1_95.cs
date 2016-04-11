using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_95 : IExecuter
    {
        public void Execute(string[] args)
        {
            try
            {
                SomeOperation();
            }
            catch (Exception)
            {
                throw; // rethrow the original exception (NotImplementedException) 
            }
        }

        private void SomeOperation()
        {
            throw new NotImplementedException();
        }
    }
}
