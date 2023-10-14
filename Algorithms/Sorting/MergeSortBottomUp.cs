using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class MergeSortBottomUp : ISort
    {
        //public static void Sort<T>(T[] array) where T : IComparable<T>{}

        private IComparable[] aux;
        private void Merge(IComparable[] a, int lo, int mid, int hight)
        {
            for (int k = lo; k <= hight; k++)
            {
                aux[k] = a[k];
            }

            int i = lo;
            int j = mid + 1;
            for (int k = lo; k <= hight; k++)
            {
                if (i > mid)
                {
                    a[k] = aux[j++];
                }
                else if (j > hight)
                {
                    a[k] = aux[i++];
                }
                else if (Less(aux[j], aux[i]))
                {
                    a[k] = aux[j++];
                }
                else
                {
                    a[k] = aux[i++];
                }
            }
        }
        
        public void Sort(IComparable[] a) {
            int N = a.Length;
            aux = new IComparable[N];
            for (int sz = 1; sz < N; sz = sz + sz)
            {
                for(int lo = 0; lo< N-sz; lo += sz + sz)
                {
                    Merge(a, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, N - 1));
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
            Console.WriteLine($"MergeSortBottomUp tests");
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

            var s = new MergeSortBottomUp();
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
