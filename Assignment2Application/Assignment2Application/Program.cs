using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new FibonacciGenerator();
            Console.WriteLine("Enter n:");
            string line = Console.ReadLine();
            int n;
            if (int.TryParse(line, out n))
            {
                long result = generator.Get(n);
                Console.WriteLine("Result: {0}", result);
            }
            else
            {
                Console.WriteLine("Cannot parse '{0}'", line);
            }
            Console.ReadLine();
        }
    }
}
