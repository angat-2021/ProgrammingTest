using System;
using System.Collections.Generic;

namespace Exercise1CWM
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            var favoriteNumbers = new List<int>() { 1,2,3,4};
            favoriteNumbers.Add(1);
            favoriteNumbers.AddRange(new int[3] { 5,6,7 });
            foreach (var favnum in favoriteNumbers)
            {
                Console.WriteLine(favnum);
            }

            
            Console.WriteLine("Index of 1: " + favoriteNumbers.IndexOf(1));
            Console.WriteLine("Index of 1: " + favoriteNumbers.LastIndexOf(1));

            Console.WriteLine("Count: "+favoriteNumbers.Count);
            for (int i = 0; i < favoriteNumbers.Count; i++)
            {
                if (favoriteNumbers[i] == 1)
                {
                    favoriteNumbers.Remove(favoriteNumbers[i]);
                }
                Console.WriteLine(favoriteNumbers[i]);
            }

            //We can not modify list inside foreach loop
           /* foreach (var favnum in favoriteNumbers)
            {
                if (favnum==1)
                {
                     favoriteNumbers.Remove(1);     
                }
            }*/


            Console.WriteLine("Index of 1: " + favoriteNumbers.IndexOf(1));
            Console.WriteLine("Index of 1: " + favoriteNumbers.LastIndexOf(1));

            Console.WriteLine("Count: " + favoriteNumbers.Count);

            //Clear method
            favoriteNumbers.Clear();
            Console.WriteLine("Count: " + favoriteNumbers.Count);




            Console.WriteLine("Please enter numbers separated by comma>>");
            string userInput = Console.ReadLine();
            string[] numbers = userInput.Split(",");

            int max = Convert.ToInt32(numbers[0]);

            foreach (var num in numbers)
            {
                int number= Convert.ToInt32(num);
                if (number>max)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);

            while (true)
            {
                Console.WriteLine("Enter your name.");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                Console.WriteLine("@Echo: "+input);
                    continue; //continues or goes back to while loop at the beginning or ignores the code inside the if statement after continue in the loop.
                    Console.WriteLine("This statement is after continue."); //will not execute
                }
                    Console.WriteLine("This statement is outside if statement.");
                    break;
            }
          /*  Console.WriteLine("Please enter a number");
            var userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput >= 1 && userInput <= 10)
            {
                Console.WriteLine("Valid number");
            }
            else
            {
                Console.WriteLine("Invalid number");   
            }

            Exercise4();
            Exercise3();
            */
        }
        public void Exercise2()
        {
            Console.WriteLine("Please enter the first number");
            var userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            var userInput2 = Convert.ToInt32(Console.ReadLine());

            var maximum = (userInput1 > userInput2) ? userInput1 : userInput2;    
            Console.WriteLine($"Maximum number is " + maximum);           
        }
        public static void Exercise3()
        {
            Console.WriteLine("Please input the width of an image");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the height of an image");
            var height = Convert.ToInt32(Console.ReadLine());

            var imageOrientation = (width > height) ? Orientation.Landscape : Orientation.Protrait;
            Console.WriteLine("ImageOrientation is: "+ imageOrientation);
        }
        public enum Orientation
        {
            Landscape,
            Protrait
        }
        public static void Exercise4()
        {
            int demerit = 0;
            Console.WriteLine("Please enter the speed limit.");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the speed of a car.");
            var speedCar = Convert.ToInt32(Console.ReadLine());
            if (speedCar<speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if((speedCar-speedLimit)>0)  
            {
                demerit = (speedCar - speedLimit) / 5;
                
                if (demerit>12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit points:"+ demerit);
                }
                
            }
        }
    }
}
