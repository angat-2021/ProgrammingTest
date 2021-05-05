using System;

namespace AccessModifiers
{ 
    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {
            //Broken the encapsulation!
            //var rating=this.CalculateRating(excludeOrders:true);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var customer = new Customer();
           // var rating=customer.CalculateRating();
        }
    }
}
