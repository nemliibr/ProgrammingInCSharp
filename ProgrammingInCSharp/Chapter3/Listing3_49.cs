using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    //Writing data to the event log - You need to run as administrator for this application 
    class Listing3_49 : IExecuter
    {
        public void Execute(string[] args)
        {
            if (!EventLog.SourceExists("MySource")) 
        { 
            EventLog.CreateEventSource("MySource", "MyNewLog"); 
            Console.WriteLine("CreatedEventSource"); 
            Console.WriteLine("Please restart application"); 
            Console.ReadKey(); 
            return; 
        } 
 
        EventLog myLog = new EventLog(); 
        myLog.Source = "MySource"; 
        myLog.WriteEntry("Log event!");
        }
    }
}
