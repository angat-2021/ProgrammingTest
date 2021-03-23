using System;

namespace Problem2
/// <summary>
/// Midterm Exam for MIS 3013 2020
/// </summary>
/// 
/// <author>
/// Angat Yogi
/// </author>

{
    class Program
    {
        static void Main(string[] args)
        {
            
            int HomePointScored = 0;
            int AwayPointScored = 0;
            int pointsScoredAway = 0;
            int PointScoredHome = 0;
            string gameOver = "";
            while (gameOver.ToUpper() != "YES")
            {

                Console.WriteLine("Who scored, \"Home Team\" or \"Away Team\"?");
                string pointScorerTeam = Console.ReadLine();

                if (pointScorerTeam.ToUpper() == "HOME"|| pointScorerTeam.ToUpper() == "H"|| pointScorerTeam.ToUpper() == "HOME TEAM")
                {
                    Console.WriteLine($"How many points did Home Team score?");
                    string pointString = Console.ReadLine();

                    while (int.TryParse(pointString, out PointScoredHome) == false)
                    {
                        Console.WriteLine($"Sorry, {pointString} is not a valid input. How many points did Home Team score: 1, 2 or 3?");
                        pointString = Console.ReadLine();
                    }
                    HomePointScored += PointScoredHome;
                    Console.WriteLine("Is game over? Type \"Yes\" or \"No\">>");
                    gameOver = Console.ReadLine();

                }

                if (pointScorerTeam.ToUpper() == "AWAY"|| pointScorerTeam.ToUpper() == "AWAY TEAM"|| pointScorerTeam.ToUpper() == "A")
                {
                    Console.WriteLine($"How many points did Away Team score?");
                    string pointString = Console.ReadLine();

                    while (int.TryParse(pointString, out pointsScoredAway) == false)
                    {
                        Console.WriteLine($"Sorry, {pointString} is not a valid input. How many points did Away Team score: 1, 2 or 3?");
                        pointString = Console.ReadLine();
                    }
                    AwayPointScored += pointsScoredAway;

                    Console.WriteLine("Is game over? Type \"Yes\" or \"No\">>");
                    gameOver = Console.ReadLine();

                }


            }

            if (HomePointScored > AwayPointScored)
            {
                Console.WriteLine($"Home Team won by {(HomePointScored - AwayPointScored).ToString("n3")} points.");
            }
            else if (HomePointScored == AwayPointScored)
            {
                Console.WriteLine($"The match is draw. {HomePointScored.ToString("n3")} points for each team.");
            }
            else
            {
                Console.WriteLine($"Away Team won by {(AwayPointScored - HomePointScored).ToString("n3")} points.");
            }
        }
    }
}
