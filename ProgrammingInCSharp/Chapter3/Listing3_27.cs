using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    //Initializing a SecureString
    class Listing3_27 : IExecuter
    {
        public void Execute(string[] args)
        {
            using (SecureString ss = new SecureString())
            {
                Console.Write("Please enter password: ");
                while (true)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter) break;

                    ss.AppendChar(cki.KeyChar);
                    Console.Write("*");
                }
                ss.MakeReadOnly();
                ConvertToUnsecureString(ss);
            }
        }

        //LISTING 3-28  Getting the value of a SecureString
        public static void ConvertToUnsecureString(SecureString securePassword)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                Console.WriteLine();
                Console.WriteLine(Marshal.PtrToStringUni(unmanagedString));
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
