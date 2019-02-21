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
    }
}
