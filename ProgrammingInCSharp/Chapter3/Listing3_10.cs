using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter3
{
    class Listing3_10 : IExecuter
    {
        public void Execute(string[] args)
        {
            string test1 = "1234AB";
            string test2 = "1234 AB";
            string test3 = "1001 AB";
            String test4 = "0000AB";
            
            Console.WriteLine("Validating test1: " + ValidateZipCode(test1));
            Console.WriteLine("Validating test1 with RegEx: " + ValidateZipCodeRegEx(test1));
            Console.WriteLine("Validating test2: " + ValidateZipCode(test2));
            Console.WriteLine("Validating test2 with RegEx: " + ValidateZipCodeRegEx(test2));
            Console.WriteLine("Validating test3: " + ValidateZipCode(test3));
            Console.WriteLine("Validating test3 with RegEx: " + ValidateZipCodeRegEx(test3));
            Console.WriteLine("Validating test4: " + ValidateZipCode(test4));
            Console.WriteLine("Validating test4 with RegEx: " + ValidateZipCodeRegEx(test4));
        }

        //LISTING 3-10  Validate a ZIP Code with a regular expression
        private bool ValidateZipCodeRegEx(string zipCode)
        {
            Match match = Regex.Match(zipCode, @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$", RegexOptions.IgnoreCase);
            return match.Success;
        }

        //LISTING 3-9  Manually validating a ZIP Code
        private bool ValidateZipCode(string zipCode)
        {
            // Valid zipcodes: 1234AB | 1234 AB | 1001 AB
            if (zipCode.Length < 6) return false;

            string numberPart = zipCode.Substring(0, 4);
            int number;
            if (!int.TryParse(numberPart, out number)) return false;

            string characterPart = zipCode.Substring(4);

            if (numberPart.StartsWith("0")) return false;
            if (characterPart.Trim().Length < 2) return false;
            if (characterPart.Length == 3 && characterPart.Trim().Length != 2)
                return false;

            return true;
        }
    }
}
