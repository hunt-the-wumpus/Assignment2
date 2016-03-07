using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Application
{
    public class FibonacciGenerator
    {
        // This class use for get n Fibonacci number
        public long Get(int n)
        {
            long current1 = 1;
            long current2 = 1;
            for (int i = 3; i <= n; ++i)
            {
                long x = current1 + current2;
                current1 = current2;
                current2 = x;
            }
            return current2;
        }
    }
}
