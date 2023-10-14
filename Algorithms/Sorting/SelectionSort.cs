using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class SelectionSort: ISort
    {
        //public static void Sort<T>(T[] array) where T : IComparable<T>{}
        /// <summary>
        /// The algorithm maintains two subarrays in a given array.
        /// The subarray which is already sorted.
        /// Remaining subarray which is unsorted.
        /// In every iteration of selection sort, the minimum element (considering ascending order) 
        /// from the unsorted subarray is picked and moved to the sorted subarray.
        /// 
        /// Therefore overall complexity = O(N)*O(N) = O(N*N) = O(N^2)
        /// Stability   : The default implementation is not stable
        /// In-place    : Yes
        /// </summary>
        /// <param name="a"></param>

        public void Sort(IComparable[] a) {
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {
                var minIndex = i;
                for (int j = i+1; j < N; j++) {
                    if (Less(a[j], a[minIndex])) {
                        minIndex = j;
                    }
                }
                Exchange(a, i, minIndex);
            }
        }

        public bool Less(IComparable v, IComparable w) {
            return v.CompareTo(w) < 0;
        }
        public void Exchange(IComparable[] a, int i, int j) {
            IComparable tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
        public void Show(IComparable[] a) {
            Console.WriteLine("***********************************");
            Console.WriteLine($"SelectionSort tests");
            Console.WriteLine("***********************************");

            var sorted = IsSorted(a);
            Console.WriteLine($"IsSorted is {sorted}");


            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public bool IsSorted(IComparable[] a) {
            for (int i = 1; i < a.Length; i++)
            {
                if (Less(a[i], a[i - 1]))
                {
                    return false;
                }
            }
            return true;
        }

        public static void RunTest() {
            int[] a = new int[] {
                9,
                2,
                4,
                3,
                1,
                -9,
                5
            };

            var s = new SelectionSort();
            IComparable[] c = new IComparable[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                c[i]  = (IComparable) a[i];
            }

            s.Sort(c);
            

            s.Show(c);

        }
    }
}
