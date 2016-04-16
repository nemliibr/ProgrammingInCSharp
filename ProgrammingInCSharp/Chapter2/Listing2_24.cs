using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Implementing an implicit and explicit conversion operator +  
    //Using an implicit and explicit cast operator on a custom type
    class Listing2_24 : IExecuter
    {
        public void Execute(string[] args)
        {
            Money m = new Money(42.42M);
            decimal amount = m;
            int truncatedAmount = (int)m;

            Console.WriteLine("amount: " + amount);
            Console.WriteLine("truncated amount: " + truncatedAmount);
        }
    }

    class Money
    {
        public decimal Amount { get; set; }

        public Money(decimal amount)
        {
            Amount = amount;
        }

        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }

        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }
    }
}
