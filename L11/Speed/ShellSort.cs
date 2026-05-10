using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    public class ShellSort : ISort
    {
        public double[] Sort(double[] array)
        {
            double[] sortedArray = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
                sortedArray[i] = array[i];

            for (int dist = sortedArray.Length / 2; dist > 0; dist /= 2)
                for (int i = dist; i < sortedArray.Length; i++)
                    for (int j = i - dist; j >= 0 && sortedArray[j] > sortedArray[j + dist]; j -= dist)
                        (sortedArray[j], sortedArray[j + dist]) = (sortedArray[j + dist], sortedArray[j]);

            return sortedArray;
        }
    }
}
