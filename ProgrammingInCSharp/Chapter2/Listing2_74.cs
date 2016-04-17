using Microsoft.CSharp;
using ProgrammingInCSharp.Interfaces;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_74 : IExecuter
    {
        public void Execute(string[] args)
        {
            CodeCompileUnit compileUnit = new CodeCompileUnit(); 
            CodeNamespace myNamespace= new CodeNamespace("MyNamespace"); 
            myNamespace.Imports.Add(new CodeNamespaceImport("System"));  
            CodeTypeDeclaration myClass = new CodeTypeDeclaration("MyClass"); 
            CodeEntryPointMethod start = new CodeEntryPointMethod(); 
            CodeMethodInvokeExpression cs1 = new CodeMethodInvokeExpression( 
            new CodeTypeReferenceExpression("Console"), "WriteLine", new CodePrimitiveExpression("Hello World!")); 
 
            compileUnit.Namespaces.Add(myNamespace); 
            myNamespace.Types.Add(myClass); 
            myClass.Members.Add(start); 
            start.Statements.Add(cs1);

            //LISTING 2-75  Generating a source file from a CodeCompileUnit
            CSharpCodeProvider provider = new CSharpCodeProvider();
            using (StreamWriter sw = new StreamWriter("HelloWorld.cs", false)) 
            { 
                IndentedTextWriter tw = new IndentedTextWriter(sw, "    "); 
                provider.GenerateCodeFromCompileUnit(compileUnit, tw, 
                new CodeGeneratorOptions()); 
                tw.Close(); 
            }
        }
    }
}
