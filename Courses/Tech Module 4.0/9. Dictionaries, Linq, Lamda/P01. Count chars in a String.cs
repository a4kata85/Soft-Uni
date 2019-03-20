using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Count_Chars_in_a_String
{
    class StartUp
    {
        static void Main()
        {
            char[] input = Console.ReadLine().Where(x => x != ' ').ToArray();

            var charCount = new Dictionary<char, int>();

            foreach (var charecter in input)
            {
                if (!charCount.ContainsKey(charecter))
                {
                    charCount[charecter] = 0;
                }
                charCount[charecter]++;
            }

            foreach (var kvp in charCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
