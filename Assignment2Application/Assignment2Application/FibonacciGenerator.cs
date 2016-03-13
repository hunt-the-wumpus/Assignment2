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
        public long Get(int n)
        {
			long cur1 = 1, cur2 = 1;
			for (int i = 3; i <= n; ++i) {
				long temp = cur2;
				cur2 += cur1;
				cur1 = temp;
			}
            return cur2;
        }
    }
}
