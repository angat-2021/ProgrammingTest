using System;
using System.Collections.Generic;
using System.Text;

namespace StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var builder1 = new StringBuilder("Angat Nath Yogi");
            builder1.Append('=', 5)
                .AppendLine()
                .Append(true);
            Console.WriteLine(builder1);
            builder1.Remove(5, 1);
            Console.WriteLine(builder1);

            var builder = new StringBuilder("Hello world");
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                 .Remove(0, 10)
                 .Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            Console.WriteLine("First Char: "+builder[0]);
            Console.WriteLine();


            var sentence = "This is going to be a really really really really really really really long sentence.";
            var summary=SummaryText.SummarizeText(sentence,30);
            Console.WriteLine(summary);
            //const int MaxLength = 20;
            //if (sentence.Length<MaxLength)
            //{
            //    Console.WriteLine(sentence);
            //}
            //else
            //{
            //    string[] words = sentence.Split(' ');
            //    var totalCharacters = 0;
            //    List<string> summaryWords = new List<string>();
            //    foreach (string word in words)
            //    {
            //        summaryWords.Add(word);
            //        totalCharacters += word.Length+ 1;
            //        if (totalCharacters>MaxLength)
            //        {
            //            break;
            //        }
            //    }
            //    string summary=String.Join(" ", summaryWords)+"...";
            //    Console.WriteLine(summary);
            //}


            //Trim

            string fullName = "Angat Yogi   ";
            Console.WriteLine("Trim: '{0}'",fullName.Trim());

            //Substring
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            //Split
           var names= fullName.Split(' ');
            Console.WriteLine("FirstName: "+names[0]);
            Console.WriteLine("LastName: "+names[1]);

            //Replace
            Console.WriteLine(fullName.Replace("Angat", "tagnA"));
            Console.WriteLine(fullName.Replace(' ', '$'));
            Console.WriteLine(fullName.Replace('a', '$'));

            //IsNullOrEmpty
            //if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid");
            }
            //IsNullOrWhiteSpace
           // if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            //Convert class
            //toInt
            var age = "25";
            int ageInt = Convert.ToInt32(age);
            //tostring
            var price = 124.54f;
            string priceStr = price.ToString("C0");
            Console.WriteLine(priceStr);//125 (rounded)


            
        }
       
    }
}
