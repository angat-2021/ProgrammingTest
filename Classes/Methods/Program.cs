using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            //var number =int.Parse("abc");
            var result=int.TryParse("abc", out number);
            if (result)
            {
            Console.WriteLine(number);
            }
            else
            {
            Console.WriteLine("Conversion failed");
            }
        }
        static void Useparams()
        {
            //params - if you need to overload the method with varying parameters then you use array but its hard to initialise an Array and pass it to the method while we call it.
            //Thus put params in the parameter declaration area in method so that we can calll the method easily without initializing an array.

            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1,2));
            Console.WriteLine(calculator.Add(1,2,3,4,5));
            Console.WriteLine(calculator.Add(1,2,3,4,500,600,466));
            Console.WriteLine(calculator.Add(new int[] { 1,2,3,4,5}));

        }
            static void UsePoints()
            {
            try
            {

            var point = new Point(10, 20);
            point.Move(null);
            Console.WriteLine("Point is at ({0}, {1})",point.X,point.Y);
            point.Move(100, 200);
            Console.WriteLine("Point is at ({0}, {1})",point.X,point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }

            }
    }
}
