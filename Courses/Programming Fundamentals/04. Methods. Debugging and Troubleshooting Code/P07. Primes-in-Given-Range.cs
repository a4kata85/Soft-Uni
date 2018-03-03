using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P07.PrimeCheckerInRange
{
    class Program
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            string printNumbers = string.Join(", ", GetPrimesInRange(startNumber, endNumber).ToArray());
            Console.WriteLine(printNumbers);
        }
        private static List<int> GetPrimesInRange(int start, int end)
        {
            var rezult = new List<int>();
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i < 2)
                {
                    isPrime = false;
                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    rezult.Add(i);
                }
            }
            return rezult;
        }
    }
}
