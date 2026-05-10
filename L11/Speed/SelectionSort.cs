using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    public class SelectionSort:ISort
    {
        public double[] Sort(double[] array)
        {
            double[] sortedArray = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
                sortedArray[i] = array[i];
            int n = array.Length;

            for(int i = 0; i < n-1;i++)
            {
                int min_idx = i;

                for(int j = i + 1; j < n; j++)
                {
                    if (sortedArray[j] < sortedArray[min_idx])
                    {
                        min_idx = j;
                    }
                }

                double temp = sortedArray[i];
                sortedArray[i] = sortedArray[min_idx];
                sortedArray[min_idx] = temp;
            }

            return sortedArray;
        }
    }
}
