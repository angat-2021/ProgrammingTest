using System;
using System.Collections.Generic;

namespace ExerciseStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem5ii();
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

        public static void Problem3()
        {
            Console.WriteLine("Enter a time value in 24-hour time format. Example, 19:00.");
            string problem3Input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(problem3Input))
                Console.WriteLine("Invalid Time");
            
            var array = problem3Input.Split(':');
            if (array[1].Length!=2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {

            if(Convert.ToInt32(array[0])<0 || Convert.ToInt32(array[0])>23 || Convert.ToInt32(array[1]) > 59|| Convert.ToInt32(array[1])<0)
            {
                Console.WriteLine("Invalid Time");
            }
            else
            {
                Console.WriteLine("Ok");
            }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }
        public static void Problem4()
        {
            Console.WriteLine("Enter words separated by space (Example: Hello everyone I hope all is well).");
            string problem4Input = Console.ReadLine();

            string[] inputs = problem4Input.Split(' ');

            string addedString = "";
            foreach(string userInput in inputs)
            {
                string lowerCaseInput = userInput.ToLower();
                string result=lowerCaseInput[0].ToString().ToUpper();
                for (int i = 1; i < lowerCaseInput.Length; i++)
                {
                    result += lowerCaseInput[i];
                }

                addedString += result;
            }
                Console.WriteLine(addedString);
        }
        public static void Problem4ii()
        {
            Console.WriteLine("Enter words separated by space (Example: Hello everyone I hope all is well).");
            string problem4Input = Console.ReadLine();

            string addedString = "";
            foreach(string userInput in problem4Input.Split(' '))
            {               
                string result=char.ToUpper(userInput[0])+ userInput.ToLower().Substring(1);
                addedString += result;
            }
                Console.WriteLine(addedString);
        }
        public static void Problem5()
        {
            Console.WriteLine("Enter an English word.");
            string input = Console.ReadLine();

            int count = 0;
            foreach (char character in input.ToLower())
            {
                if (character=='a'|| character == 'e'|| character == 'i'|| character == 'o'|| character == 'u')
                {
                    count += 1;
                }
            }
            Console.WriteLine("No of vowels in the input is: {0}",count);
        }
        public static void Problem5ii()
        {
            Console.WriteLine("Enter an English word.");
            string input = Console.ReadLine();
            List<char> characters = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            foreach (char character in input.ToLower())
            {
                if (characters.Contains(character))
                {
                    count += 1;
                }
            }
            Console.WriteLine("No of vowels in the input is: {0}",count);
        }


    }
}
