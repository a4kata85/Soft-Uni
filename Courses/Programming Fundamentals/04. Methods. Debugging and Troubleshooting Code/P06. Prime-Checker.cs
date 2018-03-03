using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P06.PrimeChecker
{
    class Program
    {
        static void Main()
        {
            long someNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(someNumber));
        }
        static bool IsPrime(long n)
        {
            int sqrtN = (int)Math.Sqrt(n);
            if (n <=1)
            {
                return false;
            }
            else if (n>2)
            {
                for (int delitel = 2; delitel <= sqrtN; delitel++)
                {
                    if (n % delitel == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
