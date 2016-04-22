using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    //Using SHA256Managed to calculate a hash code
    class Listing3_23 : IExecuter
    {
        public void Execute(string[] args)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding(); 
            SHA256 sha256 = SHA256.Create(); 
 
            string data = "A paragraph of text"; 
            byte[] hashA = sha256.ComputeHash(byteConverter.GetBytes(data)); 
            
            data = "A paragraph of changed text";
            byte[] hashB = sha256.ComputeHash(byteConverter.GetBytes(data));
            
            data = "A paragraph of text";
            byte[] hashC = sha256.ComputeHash(byteConverter.GetBytes(data));

            Console.WriteLine(hashA.SequenceEqual(hashB)); // Displays: false
            Console.WriteLine(hashA.SequenceEqual(hashC)); // Displays: true
        }
    }
}
