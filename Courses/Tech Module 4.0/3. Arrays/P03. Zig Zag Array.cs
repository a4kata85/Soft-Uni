using System;
using System.Linq;

namespace _03._ZigZagArrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            int[] numbers = new int[2];
            int numberOne = 0;
            int numberTwo = 0;

            for (int i = 0; i < n; i++)
            {
                numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                numberOne = numbers[0];
                numberTwo = numbers[1];
                                
                    if (i % 2 == 0)
                    {
                        firstArr[i] = numberOne;
                        secondArr[i] = numberTwo;
                    }
                    else
                    {
                    firstArr[i] = numberTwo;
                    secondArr[i] = numberOne;
                    }
                
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
