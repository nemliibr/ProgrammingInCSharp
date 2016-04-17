using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProgrammingInCSharp.Chapter3
{
    class Listing3_3 : IExecuter
    {
        public void Execute(string[] args)
        {
            Address a = new Address
            {
                AddressLine1 = "Somewhere 1",
                AddressLine2 = "At some floor",
                City = "SomeCity",
                ZipCode = "1111AA"
            };

            Customer c = new Customer()
            {
                FirstName = "John",
                LastName = "Doe",
                BillingAddress = null, //billing address is null
                ShippingAddress = a,
            };

            IList<ValidationResult> result = GenericValidator<Customer>.Validate(c);
            if(result != null && result.Count <= 0)
                Console.WriteLine("No errors");

            foreach (ValidationResult v in result)
                Console.WriteLine(v.ErrorMessage);
        }
    }

    public static class GenericValidator<T>
    {
        public static IList<ValidationResult> Validate(T entity)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(entity, null, null);
            Validator.TryValidateObject(entity, context, results);
            return results;
        }
    }
}
