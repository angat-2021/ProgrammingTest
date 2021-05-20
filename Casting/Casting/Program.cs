using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //var text = new Text();
            //Shape shape = text; //implicit conversion of text into shape of Shape Type
            //text.Width = 200;
            //shape.Width = 100;


            //Console.WriteLine(text.Width); //prints 100 because text and shape are references to the same object, they just have different views
            //Text test = new Text();
            //Shape shape1 = test as Shape;
            //if (shape1 != null)
            //{
            //    Console.WriteLine("Converted");
            //}
            //else
            //{
            //    Console.WriteLine("not converted");
            //}

            //if (test is Shape)
            //{
            //    Console.WriteLine("It is shape type");
            //}
            //else
            //{
            //    Console.WriteLine("It is shape type");

            //}
            #endregion

            //upcasting
            //StreamReader reader = new StreamReader(new MemoryStream());
            //ArrayList list = new ArrayList();
            //list.Add("Angat");
            //list.Add(1);
            //list.Add(new Text());

            //var anotherList = new List<Shape>();
            ////Can store any object of Shape class or any of its derived class
            //var text = new Text();
            //var tool = new Tool();
            //anotherList.Add(text);
            //anotherList.Add(tool);

            //DownCasting
            Shape shape = new Text();
            Text text = (Text)shape;
           


        }
    }
}
