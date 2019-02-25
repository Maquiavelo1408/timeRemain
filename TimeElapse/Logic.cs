using System;
using System.Collections.Generic;
using System.Text;

namespace TimeElapse
{
    public class Logic
    {
        public Logic()
        {

        }

        public TimeSpan CalculateReaminTimeInSeconds()
        {
            var now = DateTime.Now;
            var bye = new DateTime(2019, 05, 31, 12, 00, 00);
            var result = bye-now;
            return result;
        }
        public (long, double) PorcentageRemain()
        {
            var dateStart = new DateTime(2019, 02, 21, 12, 0, 0);
            var dateEnd = new DateTime(2019, 05, 31, 12, 0, 0);
            var currentDate = DateTime.Now;

            var betweenTicks = dateEnd.Ticks - dateStart.Ticks;
            var currentTicks = currentDate.Ticks - dateStart.Ticks;
            var bDays = (dateEnd - dateStart).TotalDays;
            var cDays = (currentDate - dateStart).TotalDays;
            var thirdRuleTicks = (currentTicks * 100) / betweenTicks;
            var tRD = (cDays * 100) / bDays;
            return (thirdRuleTicks, tRD);
        }

        public string DrawProgressBar(double actualPercetange)
        {
            var stringBuilder = new StringBuilder();
            var actualFloor = Math.Floor(actualPercetange);
            for(int i = 0; i<actualFloor; i++)
            {
                stringBuilder.Append("#");
            }
            for(int i = 0; i<100-actualFloor; i++)
            {
                stringBuilder.Append("-");
            }
            return stringBuilder.ToString();
        }
    }
}
