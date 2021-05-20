using System;

namespace MethodOverriding
{ public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            //any code specific to the circle itself
            Console.WriteLine("Draw a circle.");
        }

    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle.");
        }
    }
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        public abstract void Draw();
        //when a class contains a  abstract members then the class also needs to be declared as abstract. Abstract: missing implementation,
        //abstract methods are inherently virtual and can provide polymorphic behaviour. For abstract members, its derived class needs to give implementation to the method(abstract method).

    }
}
