using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{   

    public class PolyEquation :  IEquation
    {
        EquationType _eqType;
        double _x0;
        double _x1;
        double _x2;
       enum EquationType
        {
            FirstDegree,
            SecondDegree,
        }

        public PolyEquation(double x2,double x1,double x0)
        {
            _x0 = x0;
            _x1 = x1;
            _x2 = x2;
            _eqType = EquationType.SecondDegree;
        }
        
        public string Solve()
        {
            double delta = _x1 * _x1 - 4 * _x2 * _x0;
            if(_x2 == 0 && _x1 == 0 && _x0 == 0)
            {
                throw new PolyException("O infinitate de solutii", _x2, _x1, _x0);
            }
            else if(_x2==0 && _x1 == 0 )
            {
                throw new PolyException("Nicio solutie",_x2,_x1, _x0);
            }

            if (_x2 == 0)
            {
                _eqType = EquationType.FirstDegree;
                // soluție: -_x0 / _x1
                return "x1 = " + (-_x0/_x1).ToString();
            }
            else if (delta > 0)
            {
                double sqrtDelta = Math.Sqrt(delta);
                double sol1 = (-_x1 + sqrtDelta) / (2.0 * _x2);
                double sol2 = (-_x1 - sqrtDelta) / (2.0 * _x2);
                // soluții: sol1, sol2
                return "x2 = " + sol2.ToString() + " x1 = " + sol1.ToString();
            }
            else if (delta == 0)
            {
                double sol = (-_x1) / (2.0 * _x2);
                // soluție: sol
                return sol.ToString();
            }
            else
            {
                double rsol = -_x1 / (2.0 * _x2);
                double isol = Math.Sqrt(-delta) / (2.0 * _x2);
                // soluții: rsol ± isol
                return "x1 = " + rsol.ToString() + " + " + isol.ToString() + ",  x1 = " + rsol.ToString() + " - " + isol + "i";
            }
        }
    }
}
