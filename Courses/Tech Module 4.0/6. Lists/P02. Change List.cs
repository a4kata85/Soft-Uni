using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._ChangeList
{
    class StartUp
    {
        static void Main()
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = Console.ReadLine();
            

            while (true)
            {
                string[] command = line.Split();
                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "Delete")
                {
                    int numberToDelete = int.Parse(command[1]);
                    inputNumbers.RemoveAll(x => x == numberToDelete);                  
                }
                else
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    inputNumbers.Insert(position, element); 
                }
                line = Console.ReadLine();
            }
            foreach (var number in inputNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
