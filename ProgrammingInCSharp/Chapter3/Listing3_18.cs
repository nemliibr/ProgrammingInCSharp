using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    class Listing3_18 : IExecuter
    {
        public void Execute(string[] args)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string publicKeyXML = rsa.ToXmlString(false);
            string privateKeyXML = rsa.ToXmlString(true);

            Console.WriteLine(publicKeyXML);
            Console.WriteLine();
            Console.WriteLine(privateKeyXML);
            Console.WriteLine();

            //LISTING 3-19  Using a public and private key to encrypt and decrypt data
            UnicodeEncoding ByteConverter = new UnicodeEncoding(); 
            byte[] dataToEncrypt = ByteConverter.GetBytes("My Secret Data!"); 
 
            byte[] encryptedData; 
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider()) 
            { 
                RSA.FromXmlString(publicKeyXML); 
                encryptedData = RSA.Encrypt(dataToEncrypt, false); 
            }
            Console.WriteLine("Chipher text in hex: {0}", ByteArrayToHexString(encryptedData));
            Console.WriteLine();

            byte[] decryptedData; 
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider()) 
            { 
                RSA.FromXmlString(privateKeyXML); 
                decryptedData = RSA.Decrypt(encryptedData, false); 
            } 
             
            string decryptedString = ByteConverter.GetString(decryptedData); 
            Console.WriteLine(decryptedString); // Displays: My Secret Data!

            StoreKey();
            String privateKeyXML2 = LoadKey();
        }

        //LISTING 3-20  Using a key container for storing an asymmetric key
        public void StoreKey()
        {
            CspParameters csp = new CspParameters() { KeyContainerName = "SecretContainer" };
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp);
            RSA.ToXmlString(true);
        }

        public string LoadKey()
        {
            CspParameters csp = new CspParameters() { KeyContainerName = "SecretContainer" };
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp);
            return RSA.ToXmlString(true);
        }
              
        public string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}
