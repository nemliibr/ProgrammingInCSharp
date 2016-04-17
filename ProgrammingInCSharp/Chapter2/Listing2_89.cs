using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_89 : IExecuter
    {
        public void Execute(string[] args)
        {
            var stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();

            //LISTING 2-90  Using a StringReader as the input for an XmlReader
            var stringReader = new StringReader(xml);
            using (XmlReader reader = XmlReader.Create(stringReader))
            {
                reader.ReadToFollowing("price");
                decimal price = decimal.Parse(reader.ReadInnerXml(), new CultureInfo("en-US")); // Make sure that you read the decimal part correctly 
                Console.WriteLine(price);
                Console.WriteLine(price.ToString("C", new CultureInfo("en-US")));
            }
        }
    }
}
