using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03. SearchForANumber
{
    class StartUp
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> takenNumbers = new List<int>();
            takenNumbers = numbers;

            for (int i = 0; i < nums[0]; i++)
            {
                while (nums[1] > 0)
                {
                    takenNumbers.RemoveAt(0);
                    nums[1]--;
                }
            }
            if (takenNumbers.Contains(nums[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
