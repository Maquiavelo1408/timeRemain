using System;
using System.Threading;

namespace TimeElapse
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new Logic();
            while (1 < 2)
            {
                var time = logic.CalculateReaminTimeInSeconds();
                Console.WriteLine(string.Format("Ticks: {0}", time.Ticks));
                Console.WriteLine(string.Format("Milliseconds: {0}", time.TotalMilliseconds));
                Console.WriteLine(string.Format("Seconds: {0}", time.TotalSeconds));
                Console.WriteLine(string.Format("Minutes: {0}", time.TotalMinutes));
                Console.WriteLine(string.Format("Hours: {0}", time.TotalHours));
                Console.WriteLine(string.Format("Days: {0}", time.TotalDays));
                //Thread.Sleep(100);
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
