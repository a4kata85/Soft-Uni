using System;
using System.Collections.Generic;
using System.Linq;

namespace P08._Company_Users
{
    class StartUp
    {
        static void Main()
        {
            var dict = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] splitedLine = line.Split(" -> ");
                string companyName = splitedLine[0];
                string id = splitedLine[1];

                if (!dict.ContainsKey(companyName))
                {
                    List<string> someId = new List<string>();
                    someId.Add(id);
                    dict.Add(companyName, someId);
                }
                if (dict[companyName].Contains(id))
                {
                    continue;
                }
                if (dict.ContainsKey(companyName) && !dict[companyName].Contains(id))
                {
                    dict[companyName].Add(id);
                }
            }

            var sortedDict = dict.OrderBy(x => x.Key);

            foreach (var kvp in sortedDict)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
