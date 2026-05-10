using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace Speed
{
    class PerformanceCounterMeasure:IMeasure
    {
        [DllImport("kernel32", EntryPoint = "QueryPerformanceFrequency")]
        private static unsafe extern bool QueryPerformanceFrequency(Int64* f);
        [DllImport("kernel32", EntryPoint = "QueryPerformanceCounter")]
        private static unsafe extern bool QueryPerformanceCounter(Int64* c);
        static Int64 _t1, _t2, _htrFrecv;
        static bool _htrInit;
        static PerformanceCounterMeasure()
        {
            // inițializarea numărătorului - o singură dată înainte de utilizarea clasei
            InitCounter();
        }
        private static unsafe bool InitCounter()
        {
            _t1 = 0; _t2 = 0; _htrFrecv = 0; _htrInit = false;
            fixed (Int64* frecv = &_htrFrecv)
            {
                _htrInit = QueryPerformanceFrequency(frecv);
            }
            return _htrInit;
        }

        public unsafe void BeginTest()
        {
            fixed (Int64* t1 = &_t1)
            {
                QueryPerformanceCounter(t1);
            }
        }
        public unsafe double EndTest()
        {
            fixed (Int64* t2 = &_t2)
            {
                QueryPerformanceCounter(t2);
            }
            Int64 difCounts = _t2 - _t1;
            double difSeconds = (double)difCounts / (double)_htrFrecv;
            return difSeconds * 1000.0; // returnează diferența în milisecunde
        }
    }
}
