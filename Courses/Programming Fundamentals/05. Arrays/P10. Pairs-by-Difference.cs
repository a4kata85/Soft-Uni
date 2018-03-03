using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10.PairsByDifference
{
    class StartUp
    {
        static void Main()
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int found = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = elements.Length-1; j > i; j--)
                {
                    if (elements[i]- elements[j] == difference || elements[j] - elements[i] == difference)
                    {
                        found++;
                    }
                }
            }
            Console.WriteLine(found);
        }
    }
}
