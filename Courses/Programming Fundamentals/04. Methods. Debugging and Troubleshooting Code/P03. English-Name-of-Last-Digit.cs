using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.MaxMethod
{
    class Program
    {
       public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            string lastDigit = GetLastDigit(n);
            Console.WriteLine(lastDigit);
        }
        static string GetLastDigit(long number)
        {
            string digit = "zero";
            if (Math.Abs(number) % 10 == 1)
            {
                digit = "one";
            }
            else if (Math.Abs(number) % 10 == 2)
            {
                digit = "two";
            }
            else if (Math.Abs(number) % 10 == 3)
            {
                digit = "three";
            }
            else if (Math.Abs(number) % 10 == 4)
            {
                digit = "four";
            }
            else if (Math.Abs(number) % 10 == 5)
            {
                digit = "five";
            }
            else if (Math.Abs(number) % 10 == 6)
            {
                digit = "six";
            }
            else if (Math.Abs(number) % 10 == 7)
            {
                digit = "seven";
            }
            else if (Math.Abs(number) % 10 == 8)
            {
                digit = "eight";
            }
            else if (Math.Abs(number) % 10 == 9)
            {
                digit = "nine";
            }
            return digit;
        }
    }
}
