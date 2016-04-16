using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Implementing the IComparable interface
    class Listing2_54 : IExecuter
    {
        public void Execute(string[] args)
        {
            List<Order> orders = new List<Order> 
            { 
                new Order { Created = new DateTime(2012, 12, 1 )}, 
                new Order { Created = new DateTime(2012, 1, 6 )}, 
                new Order { Created = new DateTime(2012, 7, 8 )}, 
                new Order { Created = new DateTime(2012, 2, 20 )}, 
            };
            Console.WriteLine("Before sort");
            orders.ForEach(x => Console.WriteLine(x.ToString()));
            orders.Sort();
            Console.WriteLine("After sort");
            orders.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }

    class Order : IComparable
    {
        public DateTime Created { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Order o = obj as Order;

            if (o == null)
            {
                throw new ArgumentException("Object is not an Order");
            }
            return this.Created.CompareTo(o.Created);
        }

        public override string ToString()
        {
            return "Order has been created: " + Created.ToString("d", CultureInfo.CurrentCulture);
        }
    }
}
