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
        public enum TrigonometricFunction
        {
            Sin,
            Cos,
            Tan,
            Arcsin,
            Arccos
        }
        public TrigEquation(TrigonometricFunction tf, double argument)
        {
            _arg = argument;
            _function = tf;
        }
        public string Solve()
        {
           
            if (_arg < -1 || _arg>1)
            {
                throw new TrigException("Argument invalid: ", _arg);
            }
            
            double x = 0;
            switch (_function)
            {
                case TrigonometricFunction.Sin:
                    x = Math.Asin(_arg);
                    return $"x = {x} radiani";
                case TrigonometricFunction.Cos:
                    x = Math.Acos(_arg);
                    return $"x = {x} radiani";
                case TrigonometricFunction.Tan:
                    x = Math.Tan(_arg);
                    return $"x = {x} radiani";
            }
            return "";
        }
        
    }
}
