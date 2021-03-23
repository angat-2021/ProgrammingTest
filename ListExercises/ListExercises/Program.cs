using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise3();
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
            






    }
}
