using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.BombNumbers
{
    class StartUp
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] options = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bombNumber = options[0];
            int powerOfBomb = options[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int left = Math.Max(i - powerOfBomb, 0);
                    int right = Math.Min(i + powerOfBomb, numbers.Count - 1);
                    int lenght = right - left + 1;
                    numbers.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
