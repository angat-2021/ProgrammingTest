using System;
using System.Collections.Generic;
using System.IO;

namespace DebuggingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Debugging_Exercise.txt");

            List<string> words = new List<string>();

            foreach (string line in lines)
            {
                string[] separateWords = line.Split(' ');
                //char[] charToBeremoved = new char[] { ',', '.', '!', '?', '-' };
                foreach (var word in separateWords)
                {
                    words.Add(word);
                }
            }
            int max = 1;
            string longestWord="";
            foreach (var word in words)
            {
                
                if (word.Length>max)
                {
                    max = word.Length;
                    longestWord = word;
            
                }
            }

            Console.WriteLine("The longest word in the text is: "+ longestWord);
            
        }
    }
}
