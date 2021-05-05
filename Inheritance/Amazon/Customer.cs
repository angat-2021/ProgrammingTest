using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed");
            //var rating = CalculateRating(excludeOrders: true);

            //if (rating==0)
            //{
            //    Console.WriteLine("Promote to Level 1");
            //}
            //else
            //{
            //    Console.WriteLine("Promote to Level 2");
            //}
        }
        //protected int CalculateRating(bool excludeOrders)
        //{
        //    return 0;
        //}
    }
}
