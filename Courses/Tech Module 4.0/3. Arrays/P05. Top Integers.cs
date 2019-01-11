using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._TopIntegers
{
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int number = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int secondNumber = numbers[j];
                    if (number <= secondNumber)
                    {
                        break;
                    }
                    else if (j == numbers.Length - 1)
                    {
                        Console.Write(number + " ");
                    }
                }
            }

            Console.WriteLine(numbers[numbers.Length-1]);
        }
    }
}
