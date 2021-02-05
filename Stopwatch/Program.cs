using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            while (true)
            {
                Console.WriteLine("Enter 's' to start or 'x' to stop. Enter 'q' to exit.");
                var input = Console.ReadLine().ToLower();

                if (input == "s")
                {
                    stopwatch.SetStartTime();
                }
                if (input == "x")
                {
                    stopwatch.SetEndTime();
                    Console.WriteLine(stopwatch.OldDuration);
                }

                /*
                if (input == "L")
                {
                    stopwatch.SetEndTime();
                    stopwatch.SetStartTime();
                }
                */

                if (input == "q")
                break;

            }
        }
    }
}
