using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.SumReversedNumbers
{
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int rev = 0;
                while (numbers[i] > 0)
                {
                    int r = numbers[i] % 10;
                    rev = rev * 10 + r;
                    numbers[i] = numbers[i] / 10;
                }
                sum += rev;
            }
            Console.WriteLine(sum);
        }
    }
}
