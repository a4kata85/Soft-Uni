using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._ArrayRotation
{
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations % numbers.Length; i++)
            {
                int firstNumber = numbers[0];
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = firstNumber;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
