using Algorithms.ADT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Simple
{
    public class SumThree
    {
        /// <summary>
        /// Solution to find three integers in an integer array (distinct integers) that sum to 0
        /// Complexity: N^2lgN
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Count(int[] a)
        {
            Array.Sort(a);

            int N = a.Length;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i+1; j< N; j++)
                {
                    if (BinarySearch.Rank(-a[i] - a[j], a) > j)
                    {
                        count++;
                    }
                }                   
            }

            return count;
        }
    }
}
