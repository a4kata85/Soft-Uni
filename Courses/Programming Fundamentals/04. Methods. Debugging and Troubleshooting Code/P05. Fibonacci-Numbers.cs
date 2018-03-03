using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P05.FibonachiNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Fibonaci(n);
        }
        static void Fibonaci (int x)
        {
            if (x == 0 || x == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                int fib0 = 1;
                int fib1 = 1;
                int fibNext = fib0 + fib1;
                for (int i = 1; i < x-1; i++)
                {
                    fib0 = fib1;
                    fib1 = fibNext;
                    fibNext = fib0 + fib1;
                }
                Console.WriteLine(fibNext);
            }
           
        }
    }
}
