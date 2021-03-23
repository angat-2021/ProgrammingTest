using System;

namespace ProgrammingTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var season = Season.Summer;
            switch (season)
            {
                case Season.Spring:
                case Season.Summer:
                    Console.WriteLine("We've got promotion");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Sorry we don't have promotion for this season");
                    break;

                default:
                    Console.WriteLine("I dont understand the season!");
                    break;
            }
            // bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            // float price = (isGoldCustomer) ? 19.95f : 29.95f;



            //var number = 1;
            //Increment(number);
            //Console.WriteLine(number);
            //var person = new Person() { Age = 20 };
            //MakeOld(person);
            //Console.WriteLine(person.Age);

            //var Array1 = new int[3] { 1, 2, 3 };
            //var Array2 = Array1;
            //Array2[2] = 4;
            //Console.WriteLine(string.Format("Array1[2]: {0},Array2[2]: {1}", Array1[2],Array2[2]));
        }
     //   public static void Increment(int number)
        //{
        //    number += 10;
        //}
       // public static void MakeOld(Person person)
        //{
        //     person.Age+= 10;
        //}
    }
}
