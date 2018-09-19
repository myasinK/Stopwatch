using System;

namespace Mosh
{
    

    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            System.Threading.Thread.Sleep(5000);
            stopwatch.Stop();
            Console.WriteLine("Time: {0}seconds", stopwatch.Duration);
            stopwatch.Start();
            stopwatch.Reset();
            stopwatch.Start();
            System.Threading.Thread.Sleep(2000);
            stopwatch.Stop();
            Console.WriteLine("Time: {0}seconds", stopwatch.Duration);
        }
    }
}
