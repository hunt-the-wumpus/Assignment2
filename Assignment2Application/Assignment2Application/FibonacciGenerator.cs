using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Application
{
    public class FibonacciGenerator
    {
        /// <summary>
        /// Return n-th Fibonacci number.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        List<long> F;
        public FibonacciGenerator()
        {
            F = new List<long>();
            F.Add(1);
            F.Add(1);              
        }

        public long Get(int n)
        {
            if (n < F.Count)
                return F[n];
            long res = Get(n - 1) + Get(n - 2);
            F.Add(res);
            return res;
        }
    }
}
