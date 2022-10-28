using System.Diagnostics;

namespace Simulate_Stopwatch_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopW = new Stopwatch();
            stopW.Start();
            Thread.Sleep(5000);
            stopW.Stop();
            TimeSpan tspan = stopW.Elapsed;
            string elapsedTime = String.Format(" {0:00}:{1:00}:{2:00}.{3:00} ",
            tspan.Hours, tspan.Minutes, tspan.Seconds, tspan.Milliseconds / 10);
            Console.WriteLine(" RunTime " + elapsedTime);
            
        }
    }
}