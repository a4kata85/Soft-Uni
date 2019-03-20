using System;
using System.Collections.Generic;

namespace P04._Orders
{
    class StartUp
    {
        static void Main()
        {
            var dict = new Dictionary<string, double[]>();
            

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "buy")
                {
                    break;
                }

                string[] info = line.Split();
                string productName = info[0];
                double price = double.Parse(info[1]);
                int quantity = int.Parse(info[2]);

                if (!dict.ContainsKey(productName))
                {
                    dict.Add(productName, new double[2]);
                }
                dict[productName][0] = price;
                dict[productName][1] += quantity;
            }

            foreach (var kvp in dict)
            {
                var result = kvp.Value[0] * kvp.Value[1];
                Console.WriteLine($"{kvp.Key} -> {(result):f2}");
            }
        }
    }
}
