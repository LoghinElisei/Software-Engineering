using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    internal class PolyException : Exception
    {
        string _message;
        double _x0;
        double _x1;
        double _x2;

        public PolyException(string message, double x2, double x1, double x0)
        {
            _message = message;
            _x0 = x0;
            _x1 = x1;
            _x2 = x2;
        }
        public override string Message => _message + " x2 = " +_x2.ToString() + ", x1 = " + _x1.ToString() + " x0 = " + _x0.ToString();

    }
}
