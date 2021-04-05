using System;
using System.Collections.Generic;
using System.IO;

namespace Files_ReadingInCSVAndParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("geoMap.csv");
            List<string> states = new List<string>();
            List<double> soccerScores = new List<double>();
            List<double> footballScores = new List<double>();

            for (int i=3;i< lines.Length;i++)
            {
                //Regional/state, SOCCER, FOOTBALL
                //Alabama,16%,84%
                string[] lineItem = lines[i].Split(",");
                
                    string state = lineItem[0];
                    string soccerScore = lineItem[1].Trim('%');
                    
                    string footballScore = lineItem[2].Trim('%');
                    
                    states.Add(state);
                    soccerScores.Add(Convert.ToDouble(soccerScore)/100);
                    footballScores.Add(Convert.ToDouble(footballScore)/100);
                

            }

            for (int i = 0; i < footballScores.Count; i++)
            {
                string state = states[i];
                if (footballScores[i]<soccerScores[i])
                {
                    Console.WriteLine(state);
                }
            }
        }
    }
}
