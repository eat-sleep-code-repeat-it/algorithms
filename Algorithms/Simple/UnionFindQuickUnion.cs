using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Simple
{
    public class UnionFindQuickUnion
    {
        private int[] id;
        private int count;

        public void UnionFind(int N)
        {
            count = N;
            id = new int[N];
            for (int i=0; i< N; i++)
            {
                id[i] = i;
            }
        }

        public void Union(int p, int q)
        { 
            int i = Find(p);
            int j = Find(q);
            if (i == j)
            {
                return;
            }
            id[i] = j;

            count--;
        }

        public int Find(int p) 
        {
            while(p != id[p])
            {
                p = id[p];
            }

            return p;
        }

        public bool Connected(int p, int q)
        {
            return Find(p) == Find(q);
        }
        public int Count()
        {
            return count;
        }
    }
}
