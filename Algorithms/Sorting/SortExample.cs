using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class SortExample: ISort
    {
        public void Sort(IComparable[] a)
        {

        }

        public bool Less(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

        public void Exchange(IComparable[] a, int i, int j)
        {

        }

        public void Show(IComparable[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public bool IsSorted(IComparable[] a)
        {
            for(int i=1; i<a.Length; i++)
            {
                if (Less(a[i], a[i-1]))
                {
                    return false;
                }
            }
            return true;
        } 
    }
}
