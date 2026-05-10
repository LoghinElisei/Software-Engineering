using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    public interface IMeasure
    {
        void BeginTest();
        double EndTest();
    }
}
