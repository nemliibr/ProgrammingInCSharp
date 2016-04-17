using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace ProgrammingInCSharp.Chapter3
{
    //Validating an XML file with a schema
    class Listing3_16 : IExecuter
    {
        bool valid = true;

        public void Execute(string[] args)
        {
            ValidateXML();
        }

        public void ValidateXML()
        {
            string xsdPath = @"..\..\Chapter3\Listing3_14.xsd";
            string xmlPath = @"..\..\Chapter3\Listing3_14.xml";

            XmlReader reader = XmlReader.Create(xmlPath);
            XmlDocument document = new XmlDocument();
            document.Schemas.Add("", xsdPath);
            document.Load(reader);

            ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);
            document.Validate(eventHandler);
            
            if(valid)
                Console.WriteLine("xml is valid");
            else
                Console.WriteLine("xml is not valid");
        }

        public void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    valid = false;
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning {0}", e.Message);
                    valid = false;
                    break;
            }
        }
    }
}
