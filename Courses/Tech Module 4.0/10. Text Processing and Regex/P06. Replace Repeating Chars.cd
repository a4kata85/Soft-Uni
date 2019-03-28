using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P06._Replace_Repeating_Chars
{
    class StartUp
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            List<char> result = new List<char>();
            result.Add(input[0]);

            foreach (var symbol in input)
            {
                if (symbol != result.Last())
                {
                    result.Add(symbol);
                }
            }
            Console.WriteLine(string.Join("", result));

        }
    }
}
