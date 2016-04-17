using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ProgrammingInCSharp.Chapter3
{
    class Listing3_12 : IExecuter
    {
        public void Execute(string[] args)
        {
            String input = "{\"employees\":[" +
                           "{\"firstName\":\"John\", \"lastName\":\"Doe\"}," +
                           "{\"firstName\":\"Anna\", \"lastName\":\"Smith\"}," +
                           "{\"firstName\":\"Peter\", \"lastName\":\"Jones\"}" +
                           "]}";
            if (IsJson(input))
            {
                Dictionary<string, object> dictionary = ParseJson(input);
                foreach (KeyValuePair<string, object> entry in dictionary)
                {
                    Console.WriteLine(entry.Key + " : " + entry.Value.GetType().ToString());
                    ArrayList list = (ArrayList) entry.Value;
                    foreach (object obj in list)
                    {
                        Dictionary<string, object> dictionary2 = (Dictionary<string, object>)obj;
                        foreach (KeyValuePair<string, object> entry2 in dictionary2)
                        {
                            Console.WriteLine(entry2.Key + " : " + entry2.Value);
                        }
                    }
                }
            }
            else
                Console.WriteLine("The given Json file is not valid!");
            
        }

        //LISTING 3-12  Seeing whether a string contains potential JSON data
        public bool IsJson(string input) 
        { 
            input = input.Trim(); 
            return input.StartsWith("{") && input.EndsWith("}") || input.StartsWith("[") && input.EndsWith("]"); 
        }

        //LISTING 3-13  Deserializing an object with the JavaScriptSerializer
        public Dictionary<string, object> ParseJson(string input)
        {
            var serializer = new JavaScriptSerializer();
            var result = serializer.Deserialize<Dictionary<string, object>>(input);
            return result;
        }
    }
}
