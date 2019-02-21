using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._ListOperations
{
    class StartUp
    {
        static void Main()
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            while (true)
            {
                string[] line = Console.ReadLine().Split();
                if (line[0] == "End")
                {
                    break;
                }
                string command = line[0];
                if (command == "Add")
                {
                    inputNumbers.Add(int.Parse(line[1]));
                }
                else if (command == "Insert")
                {
                    int numberToAdd = int.Parse(line[1]);
                    int index = int.Parse(line[2]);
                    if (index > inputNumbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    inputNumbers.Insert(index, numberToAdd);
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(line[1]);
                    if (index > inputNumbers.Count  || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    inputNumbers.RemoveAt(index);
                }
                else if (command == "Shift")
                {
                    string direction = line[1];
                    int rotations = int.Parse(line[2]);
                    if (direction == "left")
                    {                      
                        for (int i = 0; i < rotations; i++)
                        {
                            int firstNumber = inputNumbers[0];
                            inputNumbers.Add(firstNumber);
                            inputNumbers.RemoveAt(0);
                        }
                        
                    }
                    else
                    {
                        
                        for (int i = 0; i < rotations; i++)
                        {
                            int lastNumber = inputNumbers[inputNumbers.Count - 1];
                            inputNumbers.Insert(0, lastNumber);
                            inputNumbers.RemoveAt(inputNumbers.Count-1);
                        }
                        
                    }
                }              
            }
            Console.WriteLine(string.Join(" ", inputNumbers));
        }

        
    }
}
