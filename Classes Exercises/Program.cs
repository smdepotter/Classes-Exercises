using System;

namespace Classes_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var stopWatch = new Stopwatch();
                Console.WriteLine("Hit Enter to Start, Hit Enter Again to Stop");
                var userInput = Console.ReadLine();
                stopWatch.Start();
                Console.ReadLine();
                var finalTime = stopWatch.Stop();
                Console.WriteLine(finalTime);
            }
        }
    }
}
