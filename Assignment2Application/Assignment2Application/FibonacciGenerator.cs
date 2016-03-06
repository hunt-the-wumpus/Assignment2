using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Application
{
    public class FibonacciGenerator
    {
        public long Get(int n)
        {
            if (n == 0) { return 0; }
            else
            {
                if ((n == -1) || (n == 1)) { return 1; }
                else
                {
                    if (n > 0) { return Get(n - 1) + Get(n - 2); }
                    else { return Get(n + 2) - Get(n + 1); }
                }
            }
        }
    }
}
