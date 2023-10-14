using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class QuickSortInPlace : ISort
    {
        //public static void Sort<T>(T[] array) where T : IComparable<T>{}

        public void Sort(IComparable[] a) { 
            int N = a.Length;
            int h = 1;
            while(h< N / 3)
            {
                h = 3 * h + 1;
            }

            while (h >= 1)
            {
                for (int i = h; i < N; i++)
                {
                    for (int j = i; j >= h; j=j-h)
                    {
                        if (Less(a[j], a[j - h]))
                        {
                            Exchange(a, j, j - h);
                        }
                    }
                }
            } 
        }

        private void Sort(IComparable[] a, int lo, int hight) { 
            if (hight <= lo) { 
                return; 
            }

            int j = Partition(a, lo, hight);

            Sort(a, lo, j - 1);

            Sort(a, j + 1, hight);
        }

        private int Partition(IComparable[] a, int lo, int hight) {
            int i = lo;
            int j = hight + 1;
            IComparable v = a[lo];
            while (true)
            {
                while (Less( a[++i], v))
                {
                    if (i ==hight) { break; }
                }

                while (Less(v, a[--j]))
                {
                    if (j == lo) { break; }
                }
                if (i >= j) { break; }
                Exchange(a, i, j);
            }
            Exchange(a, lo, j);
            return j;

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
            Console.WriteLine($"QuickSortInPlace tests");
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

            var s = new QuickSortInPlace();
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
