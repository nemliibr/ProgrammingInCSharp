using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    // Creating an extension method
    class Listing2_16 : IExecuter
    {
        public void Execute(string[] args)
        {
            Product p = new Product();
            p.Price = 10;
            Console.WriteLine("Price before discount: " + p.Price.ToString("c", CultureInfo.CurrentCulture));
            Console.WriteLine("Price after discount: " + p.Discount().ToString("c", CultureInfo.CurrentCulture));
        }
    }

    public class Product
    {
        public decimal Price { get; set; }
    }

    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }
}
