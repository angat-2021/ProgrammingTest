using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object initializers to avoid the use of constructors
            var customer = new Customer 
            { Id=10,
            Name="Angat",
            };

            var order = new Order();
            //customer.Orders.Add(order);
            Console.WriteLine(customer.Orders);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
