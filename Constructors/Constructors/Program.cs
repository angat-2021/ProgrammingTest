using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("XYZ1234");
            //var vehicle = new Vehicle("XYZ1234");

            //Vehicle vehicle = car;//Upcasting : Conversion from derived to base
            //Car car1 = (Car)vehicle; //Downcasting base to derived

            Vehicle vehicle = car as Vehicle;
            if (vehicle!=null)
            {
                //...
            }
            if (car is Vehicle)
            {
                Vehicle vehicle1 = (Vehicle)car;
                //...
            }
        }
    }
}
