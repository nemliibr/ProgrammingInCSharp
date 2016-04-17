using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Creating an interface that can be found through reflection
    class Listing2_69 : IExecuter
    {
        public void Execute(string[] args)
        {
            Assembly pluginAssembly = Assembly.Load("ProgrammingInCSharp");

            var plugins = from type in pluginAssembly.GetTypes()
                          where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
                          select type;

            MyApplication app = new MyApplication();
            foreach (Type pluginType in plugins) 
            { 
                IPlugin plugin = Activator.CreateInstance(pluginType) as IPlugin;
                Console.WriteLine("PlugIn name: " + plugin.Name);
                Console.WriteLine("PlugIn description: " + plugin.Description);
                plugin.Load(app);
            }
        }
    }

    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        bool Load(MyApplication application);
    }

    //LISTING 2-70  Creating a custom plug-in class
    public class MyPlugin : IPlugin 
    { 
        public string Name 
        { 
            get { return "MyPlugin"; } 
        } 
 
        public string Description 
        { 
            get { return "My Sample Plugin"; } 
        }
        
        public bool Load(MyApplication application) 
        {
            application.Start();
            return true;             
        } 
    }

    public class MyApplication
    {
        public void Start()
        {
            Console.WriteLine("My Application has been started");
        }
    }
}
