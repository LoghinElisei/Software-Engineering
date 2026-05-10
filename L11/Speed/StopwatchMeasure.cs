using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    public class StopwatchMeasure:IMeasure
    {
        private Stopwatch _stopWatch;
        public void BeginTest()
        {
            _stopWatch = new Stopwatch();
            _stopWatch.Start();
        }
        public double EndTest()
        {
            _stopWatch.Stop();
            TimeSpan ts = _stopWatch.Elapsed;
            return ts.TotalMilliseconds;
        }
    }
}
