using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Simple
{
    public class UnionFindQuickWeighted
    {
        private int[] id;   // parent link (site indexed)
        private int count;  // number of components
        private int[] sz;   // size of component for roots (site indexed)

        public void UnionFind(int N)
        {
            count = N;
            id = new int[N];            
            for (int i=0; i< N; i++)
            {
                id[i] = i;
            }

            sz = new int[N];
            for (int i = 0; i < N; i++)
            {
                sz[i] = 1;
            }
        }

        public void Union(int p, int q)
        { 
            int i = Find(p);
            int j = Find(q);
            if (i ==j)
            {
                return;
            }

            // make smaller root point to larger one.
            if (sz[i] < sz[j])
            {
                id[i] = j;
                sz[j] += sz[i];
            } else
            {
                id[j] = i;
                sz[i] += sz[j];
            }
            count--;
        }

        public int Find(int p) 
        {
            // follow links to find a root
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
