using Algorithms.ADT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Simple
{
    public class SumTwo
    {        
        /// <summary>
        /// Linearithmic solution to find the number of pairs of integers in an input array (with distinct integers) that sum to 0
        /// Complexity: NlogN
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
                if (BinarySearch.Rank(-a[i], a) > i)
                {
                    count++;
                }
            }

            return count;
        }

        public static void RunTest()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("SumTwo tests");
            Console.WriteLine("***********************************");

            int[] intArray = new int[] {
                9,
                2,
                4,
                3,
                1,
                -9,
                5
            };
            int result = SumTwo.Count(intArray);
            
            Console.WriteLine($"{nameof(SumTwo)} Result = {result}");
        }
    }
}
