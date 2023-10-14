using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Simple
{
    public class UnionFindQuickFind
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
            int pID = Find(p);
            int qID = Find(q);
            if (pID == qID)
            {
                return;
            }
            for(int i=0; i<id.Length; i++)
            {
                if (id[i] == pID)
                {
                    id[i] = qID;
                }
            }
            count--;
        }

        public int Find(int p) {
        
            return id[p];
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
