using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime
            int i = 1234;
            string s = i.ToString();//"1234"
            string t = i.ToString("C"); //"$1,234.00"
            string u = i.ToString("C0"); //"$1,234"

            var dateTime = new DateTime(2015, 1, 1);
            var now=DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("Hour: "+now.Hour);
            Console.WriteLine("Minute: "+now.Minute);

            var tomorrow=now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine("Tomorrow: "+tomorrow);
            Console.WriteLine("Yesterday: "+yesterday);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //Creatimg TimeSpan

            var timeSpan = new TimeSpan(1,2,3);
            var timeSpan1 = new TimeSpan(1, 0, 0);

            var timeSpan2=TimeSpan.FromHours(1);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: "+duration);

            //Properties

            Console.WriteLine("Minutes: "+timeSpan.Minutes);
            Console.WriteLine("Total Minutes: "+timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: "+timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: "+timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString: "+timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: "+TimeSpan.Parse("01:02:03"));


            Exercise5();
            var friendsList = new List<string>();
           
            while (true) 
            {
                Console.WriteLine("Enter your friend's name or (Hit ENTER to quit).>>");
                string newFriend = Console.ReadLine();
                friendsList.Add(newFriend);
                if (String.IsNullOrWhiteSpace(newFriend))
                {
                    break;
                }                
                switch (friendsList.Count)
                {
                    case 1:
                            Console.WriteLine($"{friendsList[0]} liked your post.");
                        break;
                    case 2:
                        Console.WriteLine($"{friendsList[0]} and {friendsList[1]} liked your post.");
                        break;
                  
                    default :
                        Console.WriteLine($"{friendsList[0]}, {friendsList[1]} and {friendsList.Count-2} others liked your post.");
                            break;
                }              
            }
            
        }
        //Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.
        //Display the reversed name on the console.
        static void Exercise2()
        {
            Console.Write("Enter your name ");
            string nameCharacters = Console.ReadLine();
            var reverseCharacters = new char[nameCharacters.Length];
            

            for (int i = nameCharacters.Length; i > 0; i--) //Angat
                reverseCharacters[nameCharacters.Length - i] = nameCharacters[i - 1];
            
                var reversed = new string(reverseCharacters);
            Console.WriteLine("Reveresed name is: {0}", reversed);
            //string reverseName = Convert.ToString(reverseCharacters);
            //Console.WriteLine(reverseName);
        }

        // Write a program and ask the user to enter 5 numbers.
        // If a number has been previously entered, display an error message and ask the user to re-try.
        // Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        static void Exercise3()
        {
            var numbers = new List<int>();
            do
            {

            Console.WriteLine("Enter a unique number>>");
            int number = Convert.ToInt32(Console.ReadLine());

            if (numbers.Contains(number))
            {
                    Console.WriteLine("Sorry you have to enter a unique number");
                    continue;
            }
                numbers.Add(number);    

            } while (numbers.Count<5);
            numbers.Sort();
            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            

        }
        static void Exercise4()
        {
            var numbers = new List<int>();
           
            string answer = "";
            while (answer.ToUpper()!="QUIT")
            {
                Console.WriteLine("Enter number or (Type Quit to exit)");
                 answer = Console.ReadLine();
                if(answer.ToUpper()!="QUIT")
                numbers.Add(Convert.ToInt32(answer));
            }

            for (int i = 0; i < numbers.Count; i++)
            {

                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numbers.Remove(numbers[i]);
                        j = 0;
                    }
                    
                }

            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        //The list of numbers may include duplicates.
        //Display the unique numbers that the user has entered.
        static void Exercise4Mosh()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number (Or type Quit to exit)");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "quit")
                    break;
                numbers.Add(Convert.ToInt32(answer));
            }
            var uniqueNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                {
                    uniqueNumbers.Add(number);
                }
            }

            foreach (var unique in uniqueNumbers)
            {
                Console.WriteLine(unique);
            }
        }

        //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        //If the list is empty or includes less than 5 numbers,
        //display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
        static void Exercise5()
        {
            var numbers = new List<int>();
            string[] numberArray;

            while (true)
            {
                Console.WriteLine("Input numbers separated by comma");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    numberArray = input.Split(",");
                    if(numberArray.Length>=5)
                    break;
                }
                
                Console.WriteLine("Invalid List. Re-Try");
            }
            var minimum = new List<int>();
            foreach (var number in numberArray)
            {
                numbers.Add(Convert.ToInt32(number));
                
            }
                //Console.WriteLine($"First number in numbers list: { numbers[0]}");
            while (minimum.Count<3)
            {
                int min = numbers[0]; 
            foreach (var  num in numbers)
            {
                if (min>num)
                {
                    min = num;
                }

            }
                minimum.Add(min);
                
                numbers.Remove(min);
            }
            Console.WriteLine("The smallest numbers in the list are: ");
            foreach (var number in minimum)
            {
                Console.WriteLine(number);
            }
        }
            






    }
}
