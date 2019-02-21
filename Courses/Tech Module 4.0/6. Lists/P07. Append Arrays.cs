using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._AppendArrays
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split('|').ToArray();
            var rezult = new List<string>();
            Array.Reverse(input);
            foreach (var token in input)
            {
                string[] numbers = token.Split(' ');
                foreach (var item in numbers)
                {
                    if (item != string.Empty)
                    {
                        rezult.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", rezult));
        }
    }
}
