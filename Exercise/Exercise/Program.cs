using System;
using System.Threading;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Hit Enter to start the stopwatch");
                Console.ReadLine();

                stopWatch.Start();

                Console.WriteLine("Hit Enter to stop the stopwatch");
                Console.ReadLine();

                stopWatch.Stop();

                Console.WriteLine($"Duration {i+1}: "+stopWatch.Interval());
                Console.WriteLine("Press Enter to run stopwatch one more time");
                Console.ReadLine();
            }

        }
    }
}
