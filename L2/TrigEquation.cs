using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    public class TrigEquation: IEquation
    {
        double _arg;
        TrigonometricFunction _function;
        enum TrigonometricFunction
        {
            Sin,
            Cos,
            Tan
        }
        TrigEquation(TrigonometricFunction tf, double argument)
        {
            _arg = argument;
            _function = tf;
        }
        public string Solve()
        {
            //switch (tf)
            //{
            //    case TrigonometricFunction.Sin:

            //}
            return "";
        }
        
    }
}
