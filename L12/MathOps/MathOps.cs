using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOps
{
    public class MathOps
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Sub(double x, double y)
        {
            return x - y; // rezultat incorect
        }
        public static double Mul(double x, double y)
        {
            return x * y; // rezultat incorect
        }
        public static double Div(double x, double y)
        {
            if (x == 0 && y == 0)
                throw new Exception("Undefined operation.");
             if (y == 0)
             throw new Exception("Division by zero."); 
            return x / y;
        }
        public static double Pow(double x, double y)
        {
            return Math.Pow(x, y);
            //throw new Exception("The method or operation is not implemented.");
        }
    }
}
