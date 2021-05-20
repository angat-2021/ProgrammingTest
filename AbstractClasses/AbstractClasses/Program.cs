using System;

namespace AbstractClasses
{ 
    class Program
    {
        static void Main(string[] args)
        {
           // var shape = new Shape();
           //Cannot create an object of an abstarct class

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

            //sealed is opposite of a abstract. It prevents the derivation of a class or overriding its members.

            
        }
    }
}
