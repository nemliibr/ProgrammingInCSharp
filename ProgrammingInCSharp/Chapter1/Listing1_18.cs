using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ProgrammingInCSharp.Interfaces;
using System.Threading;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_18 : IExecuter
    {
        public void Execute(string[] args)
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
        }

        public static async Task<string> DownloadContent() 
        { 
            using(HttpClient client = new HttpClient()) 
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result; 
           } 
        } 
    }
}
