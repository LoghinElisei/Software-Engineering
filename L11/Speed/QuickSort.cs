using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    public class QuickSort : ISort
    {
        public double[] Sort(double[] array)
        {
            double[] sortedArray = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
                sortedArray[i] = array[i];

            // alegeti una din implementari (iterativa sau recursiva)
            // varianta iterativa este de aproximativ 1.2 ori mai rapida decat cea recursiva

            DoQuickSortIterative(sortedArray, 0, sortedArray.Length - 1);
            //DoQuickSortRecursive(sortedArray, 0, sortedArray.Length - 1);

            return sortedArray;
        }

        private void DoQuickSortIterative(double[] array, int low, int high)
        {
            // https://www.geeksforgeeks.org/iterative-quick-sort/

            // Create an auxiliary stack
            int[] stack = new int[high - low + 1];

            // initialize top of stack
            int top = -1;

            // push initial values of l and h to stack
            stack[++top] = low;
            stack[++top] = high;

            // keep popping from stack while is not empty
            while (top >= 0)
            {
                // pop h and l
                high = stack[top--];
                low = stack[top--];

                // set pivot element at its correct position in sorted array
                int p = PartitionI(array, low, high);

                // if there are elements on left side of pivot, then push left side to stack
                if (p - 1 > low)
                {
                    stack[++top] = low;
                    stack[++top] = p - 1;
                }

                // if there are elements on right side of pivot, then push right side to stack
                if (p + 1 < high)
                {
                    stack[++top] = p + 1;
                    stack[++top] = high;
                }
            }
        }

        private int PartitionI(double[] array, int low, int high)
        {
            double pivot = array[high];
            int i = low - 1;  // index of smaller element

            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    (array[i], array[j]) = (array[j], array[i]);  // swap array[i] and array[j]
                }
            }

            (array[i + 1], array[high]) = (array[high], array[i + 1]);

            return i + 1;
        }

        private void DoQuickSortRecursive(double[] array, int low, int high)
        {
            if (high > low)
            {
                int k = PartitionR(array, low, high);
                DoQuickSortRecursive(array, low, k - 1);
                DoQuickSortRecursive(array, k + 1, high);
            }
        }

        private int PartitionR(double[] array, int low, int high)
        {
            int l = low, h = high;
            double x = array[l];

            while (l < h)
            {
                while ((array[l] <= x) && (l < high))
                    l++;

                while ((array[h] > x) && (h >= low))
                    h--;

                if (l < h)
                    (array[l], array[h]) = (array[h], array[l]);
            }

            (array[h], array[low]) = (array[low], array[h]);

            return h;
        }
    }
}
