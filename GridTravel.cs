using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    class GridTravel
    {
        static long[] memo = new long[200];

        internal List<Griid> ls = new List<Griid>();

        public long Grid(long m, long n){

            //ls.Add(new Griid() {Id=m, Value=n});

            long k = m + n;
            if (k == memo[k]) return memo[k];
            if (m == 1 || n == 1) return 1;
            if (m == 0 || n == 0) return 0;
            memo[k] =  Grid(m-1, n) + Grid(m, n-1);
            return memo[k];
        }
        
    }
}
