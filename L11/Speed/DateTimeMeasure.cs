using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    public class DateTimeMeasure: IMeasure
    {
        private long _startTicks;
        public void BeginTest()
        {
            _startTicks = DateTime.Now.Ticks;
        }
        public double EndTest()
        {
            double diff = (DateTime.Now.Ticks - _startTicks)/10000;
            return diff;
        }
    }
}
