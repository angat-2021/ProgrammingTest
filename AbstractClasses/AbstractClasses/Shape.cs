using System;

namespace AbstractClasses
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("The shape is copied.");
        }
        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }
    }
}
