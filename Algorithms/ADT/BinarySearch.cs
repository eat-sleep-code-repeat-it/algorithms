using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.ADT
{
    public class BinarySearch
    {
        /// <summary>
        /// recursion 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Rank(int key, int[] a)
        {
            return Rank(key, a, 0, a.Length - 1);
        }

        /// <summary>
        /// Find position of key in the integer array with binary search
        /// </summary>
        /// <param name="key"></param>
        /// <param name="a"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static int Rank(int key, int[] a, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }

            int middle = low + (high - low) / 2;
            if (key < a[middle])
            {
                return Rank(key, a, low, middle - 1);
            }
            else if (key > a[middle + 1])
            {
                return Rank(key, a, middle + 1, high);
            }
            else
            {
                return middle;
            }

        }
    }
}
