using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class BubbleSort : IComparer, IComparer<int>
    {
        #region Bubble sort

        /// <summary>
        /// Bubble sort
        /// </summary>
        /// <typeparam name="T">Type matrix</typeparam>
        /// <param name="matrixInts">Integer matrix elements</param>
        /// <param name="sortComparer">Interface realization</param>
        /// <param name="flag">Sorting direction and printioial</param>

        public static void BubbleSortAlgorithm<T>(ref int[][] matrixInts, IComparer<int> sortComparer, short flag)
        {
            if (matrixInts == null || sortComparer == null)
                throw new ArgumentNullException();

            var sizeRow = matrixInts.GetLength(0);
            int[] matrix;

            switch (flag)
            {
                case 1: matrix = SumArrayLine(matrixInts, sizeRow); break;
                case 2: matrix = SumArrayLine(matrixInts, sizeRow); break;
                case 3: matrix = MaxVal(matrixInts, sizeRow); break;
                case 4: matrix = MaxVal(matrixInts, sizeRow); break;
                case 5: matrix = MinVal(matrixInts, sizeRow); break;
                case 6: matrix = MinVal(matrixInts, sizeRow); break;
                default: throw new ArgumentOutOfRangeException();
            }

            for (var i = 0; i < sizeRow; i++)
            {
                for (var j = i; j < matrixInts.Length; j++)
                {
                    if (flag % 2 == 0)
                    {
                        if (sortComparer.Compare(matrix[i], matrix[j]) >= 0) continue;
                    }
                    else
                    {
                        if (!(sortComparer.Compare(matrix[i], matrix[j]) < 0)) continue;
                    }

                    ChangeArrayIndex(ref matrixInts, i, j);
                    Swap(ref matrix[i], ref matrix[j]);
                }
            }

        }

        #endregion


        #region auxiliary function

        /// <summary>
        /// Calculate sum of the sz-array.
        /// </summary>
        /// <param name="arrInts">Array of integer.</param>
        /// <param name="size">Size of array.</param>
        /// <returns>Array sum of the sz-array.</returns>

        private static int[] SumArrayLine(IReadOnlyList<int[]> arrInts, int size)
        {
            var sum = new int[size];
            for (var i = 0; i < size; i++)
            {
                sum[i] = arrInts[i].Sum();
            }
            return sum;
        }

        /// <summary>
        /// Search maximal element of the sz-array.
        /// </summary>
        /// <param name="arrInts">Array of integer.</param>
        /// <param name="size">Size of array.</param>
        /// <returns>Array max elements of the sz-array.</returns>

        private static int[] MaxVal(IReadOnlyList<int[]> arrInts, int size)
        {
            var maxVal = new int[size];
            int max = 0;
            for (int i = 0; i < size; i++)
            {
                max = arrInts[i][0];
                for (int j = 1; j < arrInts[i].Length; j++)
                {
                    if (max < arrInts[i][j])
                    {
                        max = arrInts[i][j];
                    }
                }
                maxVal[i] = max;
            }
            return maxVal;
        }

        /// <summary>
        /// Search minimal element of the sz-array.
        /// </summary>
        /// <param name="arrInts">Array of integer.</param>
        /// <param name="size">Size of array.</param>
        /// <returns>Array min elements of the sz-array.</returns>

        public static int[] MinVal(IReadOnlyList<int[]> arrInts, int size)
        {
            var minVal = new int[size];
            int min = 0;

            for (int i = 0; i < size; i++)
            {
                min = arrInts[i][0];
                for (int j = 1; j < arrInts[i].Length; j++)
                {
                    if (min > arrInts[i][j])
                    {
                        min = arrInts[i][j];
                    }
                }
                minVal[i] = min;
            }
            return minVal;
        }

        /// <summary>
        /// Change settings
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>

        private static void Swap(ref int a, ref int b)
        {
            var temp = b;
            b = a;
            a = temp;
        }

        /// <summary>
        /// Change index array
        /// </summary>
        /// <param name="matrixInts">Matrix</param>
        /// <param name="i">First index</param>
        /// <param name="j">Second index</param>

        private static void ChangeArrayIndex(ref int[][] matrixInts, int i, int j)
        {
            var boof = matrixInts[i];
            matrixInts[i] = matrixInts[j];
            matrixInts[j] = boof;
        }

        #endregion

        public int Compare(object x, object y)
        {
            int c1 = (int)x;
            int c2 = (int)y;
            if (c1 > c2)
                return 1;
            if (c1 < c2)
                return -1;
            else
                return 0;
        }

        public int Compare(int x, int y)
        {
            if (x > y)
                return 1;
            if (x < y)
                return -1;
            else
                return 0;
        }
    }
}
