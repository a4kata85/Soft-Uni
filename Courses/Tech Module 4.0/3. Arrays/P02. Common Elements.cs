using System;
using System.Collections.Generic;

namespace P02._CommoneElements
{
    class StartUp
    {
        static void Main()
        {
            string[] firstStrings = Console.ReadLine().Split();
            string[] secondStrings = Console.ReadLine().Split();

            List<string> commonElements = new List<string>();

            for (int i = 0; i < secondStrings.Length; i++)
            {
                for (int j = 0; j < firstStrings.Length; j++)
                {
                    if (secondStrings[i] == firstStrings[j])
                    {
                        commonElements.Add(secondStrings[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", commonElements));
        }
    }
}
