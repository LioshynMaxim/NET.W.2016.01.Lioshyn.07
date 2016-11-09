using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public interface ICompare
    {
        int Compare(int[] array1, int[] array2);
    }

    public class BubbleSort : IComparer<int[]>
    {
        #region Bubble sort

        /// <summary>
        /// Bubble sort
        /// </summary>
        /// <param name="matrixInts">Integer matrix elements</param>
        /// <param name="sortComparer">Interface realization</param>
        public static void BubbleSortAlgorithm(int[][] matrixInts, IComparer<int[]> sortComparer)
        {
            if (matrixInts == null || sortComparer == null)
                throw new ArgumentNullException();

            var sizeRow = matrixInts.GetLength(0);
            
            for (var i = 0; i < sizeRow; i++)
            {
                for (var j = i; j < matrixInts.Length; j++)
                {
                    if (sortComparer.Compare(matrixInts[i], matrixInts[j]) > 0) continue;
                        Swap(ref matrixInts[i], ref matrixInts[j]);
                }
            }

        }

        #endregion


        #region auxiliary function
        
        /// <summary>
        /// Change settings
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>

        private static void Swap(ref int[] a, ref int[] b)
        {
            var temp = b;
            b = a;
            a = temp;
        }
        

        #endregion

        public int Compare(int[] x, int[] y)
        {
            throw new NotImplementedException();
        }
    }

    public class SumUp : IComparer<int[]>
    {
        public int Compare(int[] array1, int[] array2)
        {
            if (ReferenceEquals(array1, null))
                return 1;
            if (ReferenceEquals(array2, null))
                return -1;
            return array1.Sum() - array2.Sum();
        }
    }

    public class SumDown : IComparer<int[]>
    {
        public int Compare(int[] array1, int[] array2)
        {
            if (ReferenceEquals(array1, null))
                return 1;
            if (ReferenceEquals(array2, null))
                return -1;
            return array2.Sum() - array1.Sum();
        }
    }

    public class MaxUp : IComparer<int[]>
    {
        public int Compare(int[] array1, int[] array2)
        {
            if (ReferenceEquals(array1, null))
                return 1;
            if (ReferenceEquals(array2, null))
                return -1;
            return array1.Max() - array2.Max();
        }
    }

    public class MaxDown : IComparer<int[]>
    {
        public int Compare(int[] array1, int[] array2)
        {
            if (ReferenceEquals(array1, null))
                return 1;
            if (ReferenceEquals(array2, null))
                return -1;
            return array2.Max() - array1.Max();
        }
    }

    public class MinUp : IComparer<int[]>
    {
        public int Compare(int[] array1, int[] array2)
        {
            if (ReferenceEquals(array1, null))
                return 1;
            if (ReferenceEquals(array2, null))
                return -1;
            return array1.Min() - array2.Min();
        }
    }

    public class MinDown : IComparer<int[]>
    {
        public int Compare(int[] array1, int[] array2)
        {
            if (ReferenceEquals(array1, null))
                return 1;
            if (ReferenceEquals(array2, null))
                return -1;
            return array2.Min() - array1.Min();
        }
    }
}
