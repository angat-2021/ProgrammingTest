using System;
using System.Collections.Generic;

namespace ExerciseStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem3();
        }
        static void Problem1()
        {   
            //Write a program and ask the user to enter a few numbers separated by a hyphen.
            //Work out if the numbers are consecutive.
            //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
            //display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("Please enter a few numbers, separated by hyphen '-'. For example: 56-78-89");                  
            List<int> numbersInput = new List<int>();
            foreach (var number in Console.ReadLine().Split('-'))
            {
                numbersInput.Add(Convert.ToInt32(number));
            }
            numbersInput.Sort();
            bool isConsecutivenumbers = true;
            for (int i = 1; i < numbersInput.Count; i++)
            {
                if (numbersInput[i] !=numbersInput[i-1]+1)
                {
                    isConsecutivenumbers = false;
                    break;
                }
            }
            string message = isConsecutivenumbers ? "Consecutive" : "Non consecutive";
            Console.WriteLine(message);
        }

        static void Problem2()
        {
            Console.WriteLine("Please enter a few numbers, separated by hyphen '-'. For example: 56-78-89");
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
                return;

            List<int> userNumbers = new List<int>();
            foreach (var number in input.Split('-'))
                userNumbers.Add(Convert.ToInt32(number));
            userNumbers.Sort();

            bool isDuplicate = false;
            for (int i = 1; i < userNumbers.Count; i++)
            {
                if (userNumbers[i]==userNumbers[i-1])
                {
                    isDuplicate = true;
                }
            }

            string message = isDuplicate ? "duplicate" : "Not duplicate";
            Console.WriteLine(message);
            
            
          
        }
        //Alternative solution to Q.2
        static void Problem2I()
        {
            Console.WriteLine("Enter few numbers separated by hyphen ('-').");
            string answer = Console.ReadLine();
            if (string.IsNullOrEmpty(answer))
                return;

            List<int> userNumbersProblem2 = new List<int>();
            foreach (string number in answer.Split('-'))
            {
                userNumbersProblem2.Add(Convert.ToInt32(number));
            }
            List<int> uniques = new List<int>();
            bool isUnique = true;
            foreach (int number in userNumbersProblem2)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number); 
                }
                else
                {
                    isUnique = false;
                    break;
                }
            }
            if (!isUnique)
            {
               Console.WriteLine("Duplicate");
            }
        }

        static void Problem3()
        {
            Console.WriteLine("Name Please");
            string name = Console.ReadLine();

            char[] array = new char[name.Length];

            for (int i = name.Length; i >0; i--)
            {
                array[name.Length - i] = name[i-1];
                
            }
            String reversed =new string(array);
            Console.WriteLine(reversed);
        }
    }
}
