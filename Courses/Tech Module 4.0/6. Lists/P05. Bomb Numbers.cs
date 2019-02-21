using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._BombNumbers
{
    class StartUp
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> specialNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bombNumber = specialNumbers[0];
            int power = specialNumbers[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber == bombNumber)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count-1)
                    {
                        endIndex = numbers.Count - 1;
                    }
                    if (startIndex > numbers.Count-1 || endIndex < 0)
                    {
                        continue;
                    }
                    if (true)
                    {

                    }
                    numbers.RemoveRange(startIndex, endIndex - startIndex + 1);
                    i = startIndex - 1;
                }
            }
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
