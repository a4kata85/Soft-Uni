using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._SoftUni_Parking
{
    class StartUp
    {
        static void Main()
        {
            int operations = int.Parse(Console.ReadLine());
            var registers = new Dictionary<string, string>();

            for (int i = 0; i < operations; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                string userName = input[1];

                if (command == "register")
                {
                    string plateNumber = input[2];
                    if (registers.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} registered {plateNumber} successfully");
                        registers.Add(userName, plateNumber);
                    }
                }
                else
                {
                    if (!registers.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        registers.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in registers)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
