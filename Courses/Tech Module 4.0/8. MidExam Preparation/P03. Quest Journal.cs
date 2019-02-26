using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Quests_Journal
{
    class StartUp
    {
        static void Main()
        {
            List<string> inputJurnal = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Retire!")
                {
                    break;
                }

                string[] splitedLine = line.Split(" - ");
                string command = splitedLine[0];
                string quest = splitedLine[1];

                if (command == "Start")
                {
                    if (!inputJurnal.Contains(quest))
                    {
                        inputJurnal.Add(quest);
                    }
                }
                else if (command == "Complete")
                {
                    if (inputJurnal.Contains(quest))
                    {
                        for (int i = 0; i < inputJurnal.Count; i++)
                        {
                            if (inputJurnal[i] == quest)
                            {
                                inputJurnal.Remove(quest);
                                i = i - 1;
                            }
                        }
                    }
                }
                else if (command == "Side Quest")
                {
                    string questAndSideQuest = splitedLine[1];
                    string[] splitedQuestAndSide = questAndSideQuest.Split(":");
                    string questOne = splitedQuestAndSide[0];
                    string sideQuest = splitedQuestAndSide[1];

                    if (inputJurnal.Contains(questOne) && !inputJurnal.Contains(sideQuest))
                    {
                        int index = inputJurnal.FindIndex(x => x == questOne);
                        if (index == inputJurnal.Count-1)
                        {
                            inputJurnal.Add(sideQuest);
                        }
                        else
                        {
                            inputJurnal.Insert(index + 1, sideQuest);
                        }
                    }
                }
                else if (command == "Renew")
                {
                    if (inputJurnal.Contains(quest))
                    {
                        int index = inputJurnal.FindIndex(x => x == quest);
                        string valueQuest = inputJurnal[index];
                        inputJurnal.Remove(inputJurnal[index]);
                        inputJurnal.Add(valueQuest);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", inputJurnal));
        }
    }
}
