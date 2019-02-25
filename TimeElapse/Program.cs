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
                Console.WriteLine("Fecha Inicio: 21/02/2019");
                Console.WriteLine("15/03/2019");
                Console.WriteLine(string.Format("{0}%", logic.PorcentageRemain(2019, 03, 15).Item1));
                Console.WriteLine(string.Format("{0}%", logic.PorcentageRemain(2019, 03, 15).Item2));
                Console.WriteLine(logic.DrawProgressBar(logic.PorcentageRemain(2019, 03, 15).Item2));
                var time1 = logic.CalculateReaminTimeInSeconds(2019, 03, 15);
                Console.WriteLine(new StringBuilder().Append(string.Format("Ticks: {0}", time1.Ticks)).AppendLine()
                    .Append(string.Format("Milliseconds: {0}", time1.TotalMilliseconds)).AppendLine()
                    .Append(string.Format("Seconds: {0}", time1.TotalSeconds)).AppendLine()
                    .Append(string.Format("Minutes: {0}", time1.TotalMinutes)).AppendLine()
                    .Append(string.Format("Hours: {0}", time1.TotalHours)).AppendLine()
                    .Append(string.Format("Days: {0}", time1.TotalDays)).AppendLine().ToString());
                Console.WriteLine("31/03/2019");
                Console.WriteLine(string.Format("{0}%", logic.PorcentageRemain(2019, 03, 31).Item1));
                Console.WriteLine(string.Format("{0}%", logic.PorcentageRemain(2019, 03, 31).Item2));
                Console.WriteLine(logic.DrawProgressBar(logic.PorcentageRemain(2019, 03, 31).Item2));
                var time3 = logic.CalculateReaminTimeInSeconds(2019, 03, 31);
                Console.WriteLine(new StringBuilder().Append(string.Format("Ticks: {0}", time3.Ticks)).AppendLine()
                    .Append(string.Format("Milliseconds: {0}", time3.TotalMilliseconds)).AppendLine()
                    .Append(string.Format("Seconds: {0}", time3.TotalSeconds)).AppendLine()
                    .Append(string.Format("Minutes: {0}", time3.TotalMinutes)).AppendLine()
                    .Append(string.Format("Hours: {0}", time3.TotalHours)).AppendLine()
                    .Append(string.Format("Days: {0}", time3.TotalDays)).AppendLine().ToString());

                Console.WriteLine("30/04/2019");
                Console.WriteLine(string.Format("{0}%", logic.PorcentageRemain(2019, 04, 30).Item1));
                Console.WriteLine(string.Format("{0}%", logic.PorcentageRemain(2019, 04, 30).Item2));
                Console.WriteLine(logic.DrawProgressBar(logic.PorcentageRemain(2019, 04, 30).Item2));
                var time2 = logic.CalculateReaminTimeInSeconds(2019, 04, 30);
                Console.WriteLine(new StringBuilder().Append(string.Format("Ticks: {0}", time2.Ticks)).AppendLine()
                    .Append(string.Format("Milliseconds: {0}", time2.TotalMilliseconds)).AppendLine()
                    .Append(string.Format("Seconds: {0}", time2.TotalSeconds)).AppendLine()
                    .Append(string.Format("Minutes: {0}", time2.TotalMinutes)).AppendLine()
                    .Append(string.Format("Hours: {0}", time2.TotalHours)).AppendLine()
                    .Append(string.Format("Days: {0}", time2.TotalDays)).AppendLine().ToString());


                Console.WriteLine("31/05/2019");
                Console.WriteLine(string.Format("{0}%", logic.PorcentageRemain(2019, 05, 31).Item1));
                Console.WriteLine(string.Format("{0}%", logic.PorcentageRemain(2019, 05, 31).Item2));
                Console.WriteLine(logic.DrawProgressBar(logic.PorcentageRemain(2019, 05, 31).Item2));
                var time = logic.CalculateReaminTimeInSeconds(2019, 05, 31);
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
