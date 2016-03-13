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
            if (n == 0)
            {
                return 0;
            }

            long cur1 = 0;
            long cur2 = 1;
            for (int i = 0; i < n - 1; i++)
            {
                long temp = cur2;
                cur2 = cur1 + cur2;
                cur1 = temp; 
            }
            return cur2;
        }
    }
}
