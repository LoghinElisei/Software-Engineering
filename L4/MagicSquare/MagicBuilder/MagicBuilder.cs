/**************************************************************************
 *                                                                        *
 *  File:        MagicBuilder.cs                                          *
 *  Copyright:   (c) 2026, Loghin Elisei                              *
 *  E-mail:      elisei.loghin2@student.tuiasi.ro                         *
 *  Website:     https://github.com/LoghinElisei                          *
 *  Description: Calculates magic squares of any size                     *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;

namespace MagicSquare
{
    /// <summary>
    /// Clasa pentru construirea unui pătrat magic
    /// </summary>
    public class MagicBuilder
    {
        private int[,] _matrix;
        private int _size;

        /// <summary>
        /// Constructorul clasei pentru pătratul magic
        /// </summary>
        /// <param name="size">Dimensiunea pătratului</param>
        public MagicBuilder(int size)
        {
            _size = size;
            _matrix = new int[size, size];
        }

        /// <summary>
        /// Metoda care returnează pătratul construit
        /// </summary>
        /// <returns>Matricea corespunzătoare pătratului magic</returns>
        public int[,] BuildMagicSquare()
        {
            if (_size < 1 || _matrix == null)
                throw new Exception("Dimensiune incorecta");
            MagicSquare(_matrix, _size);
            return _matrix;
        }

        /// <summary>
        /// Determină tipul de algoritm necesar în funcție de dimensiunea n.
        /// </summary>
        /// <param name="matrix">Matricea în care se vor scrie valorile.</param>
        /// <param name="n">Dimensiunea pătratului.</param>
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

        /// <summary>
        /// Algoritm pentru pătrate magice de ordin impar
        /// </summary>
        /// <param name="matrix">Matricea țintă.</param>
        /// <param name="n">Dimensiunea impară.</param>
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

        /// <summary>
        /// Algoritm pentru pătrate magice de ordin dublu par (divizibil cu 4).
        /// </summary>
        /// <param name="matrix">Matricea țintă.</param>
        /// <param name="n">Dimensiunea (multiplu de 4).</param>
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

        /// <summary>
        /// Algoritm pentru pătrate magice de ordin simplu par (divizibil cu 2, dar nu cu 4).
        /// </summary>
        /// <param name="matrix">Matricea țintă.</param>
        /// <param name="n">Dimensiunea (pară, non-multiplu de 4).</param>
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