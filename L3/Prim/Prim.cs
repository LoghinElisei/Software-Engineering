using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prim
{
    public class Prim
    {
        public static bool isPrim(int x)
        {
            if (x == 0 || x == 1)
               return false;
            if (x == 2)
                return true;
            if( x % 2 == 0)
                return false;
            for ( int d = 3; d*d <= x;d+=2)
            {
                if (x % d == 0)
                    return false;
            }
            return true;
        }
        public static int numaraPrime(int x)
        {
            int res = 0;
        
            for(int i=2; i <= x; i++)
            {
                if ( Prim.isPrim(i))
                {
                    res++;
                }
            }
            return res;
        }
    }
}
