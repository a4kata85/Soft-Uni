using System;
using System.Linq;

namespace P07._MaxSeqOfEqualElem
{
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxRepeats = 1;
            int repeats = 1;
            int number = 0;
            int printingRepeats = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length-1)
                {
                    break;
                }

                if (numbers[i] == numbers[i+1])
                {
                    repeats++;
                    if (repeats > printingRepeats)
                    {
                        maxRepeats = repeats;
                        number = numbers[i];
                        printingRepeats = maxRepeats;
                    }                   
                }
                else
                {
                    repeats = 1;
                    maxRepeats = 1;
                }
            }

            for (int i = 0; i < printingRepeats; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
