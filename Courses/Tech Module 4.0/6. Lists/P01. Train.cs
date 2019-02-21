using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Train
{
    class StartUp
    {
        

        static void Main()
        {
            List<int> wagonsPeople =  Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPeople = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            List<int> finalList = new List<int>();

            while (true)
            {
                if (command == "end")
                {
                    foreach (var people in wagonsPeople)
                    {
                        Console.Write(people + " ");
                    }
                    Console.WriteLine();
                    break;
                }
                string[] actions = command.Split().ToArray();
                if (actions[0] == "Add")
                {
                    int countPeople = int.Parse(actions[1]);
                    wagonsPeople.Add(countPeople);                 
                }
                else
                {
                    finalList = AddPeopleIfPossible(wagonsPeople, int.Parse(actions[0]), maxPeople);
                }
                command = Console.ReadLine();
            }
            
        }

        public static List<int> AddPeopleIfPossible(List<int> wagonsPeople, int people, int max)
        {
            
            for (int i = 0; i < wagonsPeople.Count; i++)
            {
                if (people + wagonsPeople[i] > max)
                {
                    continue;
                }
                else
                {
                    wagonsPeople[i] += people;
                    return wagonsPeople;
                }
            }
            return wagonsPeople;
        }
    }
}
