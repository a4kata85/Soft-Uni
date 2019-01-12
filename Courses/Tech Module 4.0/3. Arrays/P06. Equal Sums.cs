using System;
using System.Linq;

namespace P06._EqualSums
{
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int rightIndex = i + 1; rightIndex < numbers.Length; rightIndex++)
                {
                    rightSum += numbers[rightIndex];
                }

                for (int leftIndex = 0; leftIndex < i; leftIndex++)
                {
                    leftSum += numbers[leftIndex];
                }

                if (leftSum == rightSum)
                {
                    index = i;
                }

                rightSum = 0;
                leftSum = 0;
            }

            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
