using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    class Listing3_25 : IExecuter
    {
        public void Execute(string[] args)
        {
            DeclarativeCAS();
            Demo();
        }

        [FileIOPermission(SecurityAction.Demand, AllLocalFiles = FileIOPermissionAccess.Read)]
        public void DeclarativeCAS()
        {
            Console.WriteLine("Hello World");
        }

        //LISTING 3-26 Imperative CAS
        public void Demo()
        {
            FileIOPermission f = new FileIOPermission(PermissionState.None);
            f.AllLocalFiles = FileIOPermissionAccess.Read;
            try
            {
                f.Demand();
                Console.WriteLine("Hello World");
            }
            catch (SecurityException s)
            {
                Console.WriteLine(s.Message);
            }
        }
        
    }
}
