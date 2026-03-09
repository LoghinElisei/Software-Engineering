/**************************************************************************
 *                                                                        *
 *  File:        MagicBuilder.cs                                          *
 *  Copyright:   (c) 2003, A. Riazi                                       *
 *  Website:     http://www.codeproject.com/KB/recipes/Magic_Square.asp   *
 *  Description: Calculates magic squares of any size.                    *
 *               Translated into C# and adapted by Florin Leon            *
 *               http://florinleon.byethost24.com/lab_ip.htm              *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;

namespace MagicSquare
{
    public class MagicBuilder
    {
        private int[,] _matrix;
        private int _size;

        public MagicBuilder(int size)
        {
            _size = size;
            _matrix = new int[size, size];
        }

        public int[,] BuildMagicSquare()
        {
            if (_size < 1 || _matrix == null)
                throw new Exception("Dimensiune incorecta");
            MagicSquare(_matrix, _size);
            return _matrix;
        }

        private void MagicSquare(int[,] matrix, int n)
        {
            if (n % 2 == 1) // n is odd
                OddMagicSquare(matrix, n);
            else // n is even
            {
                if (n % 4 == 0) // doubly even order
                    DoublyEvenMagicSquare(matrix, n);
                else // singly even order
                    SinglyEvenMagicSquare(matrix, n);
            }
        }

        private void OddMagicSquare(int[,] matrix, int n)
        {
            int nsqr = n * n;
            int i = 0, j = n / 2;     // start position

            for (int k = 1; k <= nsqr; ++k)
            {
                matrix[i, j] = k;

                i--;
                j++;

                if (k % n == 0)
                {
                    i += 2;
                    --j;
                }
                else
                {
                    if (j == n)
                        j -= n;
                    else if (i < 0)
                        i += n;
                }
            }
        }

        private void DoublyEvenMagicSquare(int[,] matrix, int n)
        {
            int[,] mat1 = new int[n, n];
            int[,] mat2 = new int[n, n];

            int i, j;

            //prepare mat1, mat2
            int index = 1;
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {
                    mat1[i, j] = ((i + 1) % 4) / 2;
                    mat2[j, i] = ((i + 1) % 4) / 2;
                    matrix[i, j] = index;
                    index++;
                }

            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {
                    if (mat1[i, j] == mat2[i, j])
                        matrix[i, j] = n * n + 1 - matrix[i, j];
                }
        }

        private void SinglyEvenMagicSquare(int[,] matrix, int n)
        {
            int p = n / 2;

            int[,] mat = new int[p, p];
            MagicSquare(mat, p);

            int i, j, k;

            for (i = 0; i < p; i++)
                for (j = 0; j < p; j++)
                {
                    matrix[i, j] = mat[i, j];
                    matrix[i + p, j] = mat[i, j] + 3 * p * p;
                    matrix[i, j + p] = mat[i, j] + 2 * p * p;
                    matrix[i + p, j + p] = mat[i, j] + p * p;
                }

            if (n == 2)
                return;

            int[] mat1 = new int[p];
            List<int> vect = new List<int>();

            for (i = 0; i < p; i++)
                mat1[i] = i + 1;

            k = (n - 2) / 4;

            for (i = 1; i <= k; i++)
                vect.Add(i);

            for (i = n - k + 2; i <= n; i++)
                vect.Add(i);

            int temp;
            for (i = 1; i <= p; i++)
                for (j = 1; j <= vect.Count; j++)
                {
                    temp = matrix[i - 1, vect[j - 1] - 1];
                    matrix[i - 1, vect[j - 1] - 1] = matrix[i + p - 1, vect[j - 1] - 1];
                    matrix[i + p - 1, vect[j - 1] - 1] = temp;
                }

            i = k;
            j = 0;
            temp = matrix[i, j]; matrix[i, j] = matrix[i + p, j]; matrix[i + p, j] = temp;

            j = i;
            temp = matrix[i + p, j]; matrix[i + p, j] = matrix[i, j]; matrix[i, j] = temp;
        }
    }
}