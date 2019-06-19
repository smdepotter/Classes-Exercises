using System;

namespace Classes_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Design a class called Stopwatch. The job of this class is to simulate a stopwatch.
             It should provide two methods: Start and Stop. We call the start method ﬁrst, and the stop method next.
             Then we ask the stopwatch about the duration between start and stop. Duration should be a value in TimeSpan.
             Display the duration on the console
             */
            while (true)
            {
                var stopWatch = new Stopwatch();
                Console.WriteLine("Hit Enter to Start, Hit Enter Again to Stop");
                Console.ReadLine();
                stopWatch.Start();
                Console.ReadLine();
                Console.WriteLine(stopWatch.Stop());
            }
        }
    }
}
