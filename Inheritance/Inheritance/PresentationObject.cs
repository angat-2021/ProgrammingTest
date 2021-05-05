using System;

namespace Inheritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("The object copied to clipboard.");
        }
        public void Duplicate()
        {
            Console.WriteLine("The object was duplicated.");
        }
    }   
}
