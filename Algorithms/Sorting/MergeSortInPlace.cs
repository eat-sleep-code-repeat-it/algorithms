using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class MergeSortInPlace : ISort
    {
        //public static void Sort<T>(T[] array) where T : IComparable<T>{}

        private IComparable[] aux;
        private void Merge(IComparable[] a, int lo, int mid, int hight)
        {
            int i = lo;
            int j = mid + 1;
            for (int k=lo; k<=hight; k++)
            {
                aux[k] = a[k];
            }

            for (int k = lo; k <= hight; k++)
            {
                if (i > mid)
                {
                    //a[k] = aux[j++];
                    a[k] = aux[j];
                    j = j + 1;
                }
                else if (j> hight)
                {
                    // a[k] = aux[i++];
                    a[k] = aux[i];
                    i = i + 1;
                }
                else if (Less(aux[j], aux[i]))
                {
                    // a[k] = aux[j++];
                    a[k] = aux[j++];
                    j = j + 1;
                }
                else
                {
                    //a[k] = aux[i++];
                    a[k] = aux[i++];
                    i = i + 1;
                }
            }
        }
        
        public void Sort(IComparable[] a) {
            aux = new IComparable[a.Length];
            Sort(a, 0, a.Length - 1);
        }
        private void Sort(IComparable[] a, int lo, int hight)
        {
            if (hight <= lo)
            {
                return;
            }

            int mid = lo + (hight - lo) / 2;
            Sort(a, lo, mid);
            Sort(a, mid + 1, hight);

            Merge(a, lo, mid, hight);
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
            Console.WriteLine($"MergeSortInPlace tests");
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

            var s = new MergeSortInPlace();
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
