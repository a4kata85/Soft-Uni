using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12.MasterNumbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                if (IsPalindrome(i.ToString()) && SumDiv(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsPalindrome( string n)
        {
            for (int i = 0; i < n.Length/2; i++)
            {
                if (n[i] != n[n.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }
        static bool SumDiv(int n)
        {
            bool evenDigit = false;
            bool devisible = false;
            int sum = 0;
            while (n != 0)
            {
                int lastDigit =n % 10;
                if (lastDigit % 2 == 0)
                {
                    evenDigit = true;
                }
                sum = sum + lastDigit;
                n = n / 10;
            }
            if (sum % 7 == 0)
            {
                devisible = true;
            }
            if (evenDigit && devisible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
