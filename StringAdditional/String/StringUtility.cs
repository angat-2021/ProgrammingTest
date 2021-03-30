using System;
using System.Collections.Generic;
using System.Text;

namespace StringFormatting
{
    public class SummaryText
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }

            string[] words = text.Split(' ');
            var totalCharacters = 0;
            List<string> summaryWords = new List<string>();
            foreach (string word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                {
                    break;
                }
            }
            //string summary = String.Join(" ", summaryWords) + "...";
            //return summary;
            return String.Join(" ", summaryWords) + "...";

        }
    }
}
