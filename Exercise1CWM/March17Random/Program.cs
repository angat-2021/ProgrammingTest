using System;

namespace March17Random
{
    class Program
    {
        static void Main(string[] args)
        {
            //var rand = new Random();
            //int randomNumber = rand.Next(1, 7);

            //Console.WriteLine((int)'a'); //97 z=122
            Exercise5();
            Exercise4();
            Exercise3();
            Exercise1();
            Exercise2();

            Random rand = new Random();
            const int PasswordLength = 10;
            char[] buffer = new char[PasswordLength];
            
            for (int i = 0; i < PasswordLength; i++)
                buffer[i] = (char)('a' + rand.Next(0, 26));
                                  
              
            string  password = new string(buffer);             
            
            Console.WriteLine(password);
            
        }
        static void Exercise1()
        {
            int count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i%3==0)
                {
                     count++;
                }
            }
            Console.WriteLine($"{count} numbers in between  1 and 100 are divisible by 3.");
        }
       static void Exercise2()
        {
            string answer = " ";
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter the numbers you want to add or type 'ok' to exit.");
                answer = Console.ReadLine();

                if (answer.ToLower()=="ok")
                {
                    break;
                }
                               
                sum += Convert.ToInt32(answer);              
            }
            Console.WriteLine($"Sum is {sum}.");
        }

        static void Exercise3()
        {
            Console.WriteLine("Enter a number to find the factorial of it");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial=1;
            for (int i = 1; i <= number; i++)
            {
                //Console.WriteLine(i);
                factorial *= i;
            }
            Console.WriteLine("{0}!={1}",number,factorial);

        }
        static void Exercise4()
        {
            Random rand = new Random();
            int number = rand.Next(1, 10);
            Console.WriteLine(number);
            //int i = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess a number between 1 and 10>>");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (number == userNumber)
                {
                    Console.WriteLine("You won");
                    return;
                }
            }

            Console.WriteLine("Sorry you lost.");
            /* while (i<4)
             {
             Console.WriteLine("Guess a number between 1 and 10>>");
             int userNumber = Convert.ToInt32(Console.ReadLine());

                 if (number==userNumber)
                 {
                     Console.WriteLine("You won");
                 }
                 i++;
             if (number != userNumber&&i>=4)
             {
             Console.WriteLine("Sorry you lost.");

             }
             }*/
        }

        static void Exercise5()
        {
            Console.WriteLine("Enter the series of number separated by comma");

            string userInput = Console.ReadLine();

            string[] numbers = userInput.Split(",");

            int max= Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                 int number = Convert.ToInt32(str);

                if (number>max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"Max = {max}");
        }
    }
}
