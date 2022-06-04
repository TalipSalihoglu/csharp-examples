using System;
using System.Threading;

namespace IntermediateOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StopWatch watch = new StopWatch();
            watch.Start();
            Thread.Sleep(3000);
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
        }
    }
}
