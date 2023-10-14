using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public interface ISort
    {
        public void Sort(IComparable[] a);
        public bool Less(IComparable v, IComparable w);
        public void Exchange(IComparable[] a, int i, int j);
        public void Show(IComparable[] a);
        public bool IsSorted(IComparable[] a); 
    }
}
