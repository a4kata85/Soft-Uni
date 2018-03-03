using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.RotateAndSum
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] sum = new int[input.Count];

            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                input.Insert(0, input[input.Count - 1]);
                input.RemoveAt(input.Count - 1);

                for (int j = 0; j < input.Count; j++)
                {
                    sum[j] = sum[j] + input[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
