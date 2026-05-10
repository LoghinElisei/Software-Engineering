using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    public class BubbleSort: ISort
    {
        public double[] Sort(double[] array)
        {
            double[] a = new double[array.Length];
            for (int i = 0; i < array.Length; i++) a[i] = array[i];

            int n = a.Length;
            int lim = n - 1; 
            int ok;

            do
            {
                ok = 0;
                for (int i = 0; i < lim; i++)
                {  
                    if (a[i] > a[i + 1]) 
                    {
                        double aux = a[i]; 
                        a[i] = a[i + 1];
                        a[i + 1] = aux; 
                        ok = 1;
                    }
                }
                lim = lim - 1;
            } while (ok == 1);
            
            return a;
        }
    }
}
