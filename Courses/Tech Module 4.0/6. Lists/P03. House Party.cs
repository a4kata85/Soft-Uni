using System;
using System.Collections.Generic;

namespace P03._HouseParty
{
    class StartUp
    {
        static void Main()
        
{
            int numberOfComands = int.Parse(Console.ReadLine());
            List<string> resultNames = new List<string>();
            string[] line = Console.ReadLine().Split();

            for (int i = 0; i < numberOfComands; i++)
            {
                string name = line[0];
                if (line[2] == "going!")
                {
                       if(resultNames.Contains(name))
                        {
                            Console.WriteLine($"{name} is already in the list!");
                        }
                        else
                        {
                            resultNames.Add(name);
                        }
                }
                else
                {
                        if (resultNames.Contains(name))
                        {
                            resultNames.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"{name} is not in the list!");
                        }
                }
                if (i == numberOfComands -1)
                {
                    break;
                }
                else
                {
                    line = Console.ReadLine().Split();
                }
            }
            foreach (var names in resultNames)
            {
                Console.WriteLine(names);
            }
        }
    }
}
