using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            Shape shape = text;
            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);
        }
    }
}
