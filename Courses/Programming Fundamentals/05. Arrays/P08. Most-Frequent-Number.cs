using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MostFrequentNumber
{
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int mostFreqNumber = 0;
            int repeats = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int counter = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (currentNumber == numbers[j])
                    {
                        counter++;
                    }
                }

                if (counter > repeats)
                {
                    mostFreqNumber = currentNumber;
                    repeats = counter;
                }
            }

            Console.WriteLine("{0}", mostFreqNumber);
        }
    }
}
