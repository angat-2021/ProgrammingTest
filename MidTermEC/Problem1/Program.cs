using System;
/// <summary>
/// Midterm Exam for MIS 3013 2020
/// </summary>
/// 
/// <author>
/// Angat Yogi
/// </author>

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Angat Yogi
            Console.WriteLine("What sport is the ticket for?");
            string sportName = Console.ReadLine().ToUpper();
            Console.WriteLine("What is the cost of the ticket?");
            string ticketPrice = Console.ReadLine();

            Console.WriteLine($"Congatulations we found your seat. Your seat is located at \"{sportName[sportName.Length-1]}{ticketPrice[0]}\"");
            
        }
    }
}
