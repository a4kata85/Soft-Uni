using System;
using System.Collections.Generic;

namespace P02._A_Miner_Task
{
    class StartUp
    {
        static void Main()
        {
            var resource = new Dictionary<string, int>();
            

            while (true)
            {
                string resor = Console.ReadLine();
                if (resor == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!resource.ContainsKey(resor))
                {
                    resource.Add(resor, quantity);
                }
                else
                {
                    resource[resor] += quantity;
                }
            }

            foreach (var kvp in resource)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
