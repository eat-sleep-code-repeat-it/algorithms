using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class BubbleSort : ISort
    {
        /// <summary>
        /// 
        /// 
        /// Time Complexity: O(N^2) 
        /// Stability   : Yes
        /// In-place    : Yes
        /// </summary>
        /// <param name="a"></param>
        public void Sort(IComparable[] a)
        {
            int N = a.Length;
            bool swapped;
            for (int i = 0; i < N - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < N - i - 1; j++)
                {
                    if (Less(a[j + 1], a[j]))
                    {
                        Exchange(a, j + 1, j);
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break;
                }                    
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
            Console.WriteLine($"BubbleSort tests");
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

            var s = new BubbleSort();
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
