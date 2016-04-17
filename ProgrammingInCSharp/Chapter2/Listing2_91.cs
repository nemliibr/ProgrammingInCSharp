using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_91 :IExecuter
    {
        public void Execute(string[] args)
        {
            string value = "My Sample Value"; 
            int indexOfp = value.IndexOf('p'); // returns 6 
            int lastIndexOfm = value.LastIndexOf('m'); // returns 5
            Console.WriteLine("index of p: " + indexOfp);
            Console.WriteLine("last index of m: " + lastIndexOfm);

            //LISTING 2-92  Using StartsWith and EndsWith
            value = "<mycustominput>"; 
            if (value.StartsWith("<"))
                Console.WriteLine(value + " starts with <");
            else
                Console.WriteLine(value + " doesn't starts with <");

            if (value.EndsWith(">"))
                Console.WriteLine(value + " ends with >");
            else
                Console.WriteLine(value + " doesn't end with >");

            //LISTING 2-93  Reading a substring
            value = "My Sample Value"; 
            string subString = value.Substring(3, 6); // Returns ‘Sample’
            Console.WriteLine("substring: " + subString);

            //LISTING 2-94  Changing a string with a regular expression
            string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )"; 
            string[] names = {"Mr. Henry Hunt", "Ms. Sara Samuels", "Abraham Adams", "Ms. Nicole Norris" }; 
 
            foreach (string name in names) 
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));

            //LISTING 2-95  Iterating over a string
            value = "My Custom Value"; 
            foreach (char c in value) 
                Console.WriteLine(c);

            //LISTING 2-96  Overriding ToString
            Person p = new Person("John", "Doe");
            Console.WriteLine(p);
            Console.WriteLine(p.ToString("G"));
            Console.WriteLine(p.ToString("FL"));
            Console.WriteLine(p.ToString("LF"));
            Console.WriteLine(p.ToString("FSL"));
            Console.WriteLine(p.ToString("LSF"));

            //LISTING 2-97  Displaying a number with a currency format string
            double cost = 1234.56; 
            Console.WriteLine(cost.ToString("C", new CultureInfo("en-US"))); // Displays $1,234.56
            Console.WriteLine(cost.ToString("C", CultureInfo.CurrentCulture));

            //LISTING 2-98  Displaying a DateTime with different format strings
            DateTime d = new DateTime(2013, 4, 22); 
            CultureInfo provider = new CultureInfo("en-US"); 
            Console.WriteLine(d.ToString("d", provider)); // Displays 4/22/2013 
            Console.WriteLine(d.ToString("D", provider)); // Displays Monday, April 22, 2013 
            Console.WriteLine(d.ToString("M", provider)); // Displays April 22
        }
    }
}
