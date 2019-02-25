using System;
using System.Text;
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
                Console.WriteLine(string.Format("{0}%", logic.PorcentageRemain().Item1));
                Console.WriteLine(string.Format("{0}%", logic.PorcentageRemain().Item2));
                Console.WriteLine(logic.DrawProgressBar(logic.PorcentageRemain().Item2));
                var time = logic.CalculateReaminTimeInSeconds();
                Console.WriteLine(new StringBuilder().Append(string.Format("Ticks: {0}", time.Ticks)).AppendLine()
                    .Append(string.Format("Milliseconds: {0}", time.TotalMilliseconds)).AppendLine()
                    .Append(string.Format("Seconds: {0}", time.TotalSeconds)).AppendLine()
                    .Append(string.Format("Minutes: {0}", time.TotalMinutes)).AppendLine()
                    .Append(string.Format("Hours: {0}", time.TotalHours)).AppendLine()
                    .Append(string.Format("Days: {0}", time.TotalDays)).AppendLine().ToString());
                //Thread.Sleep(100);
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
