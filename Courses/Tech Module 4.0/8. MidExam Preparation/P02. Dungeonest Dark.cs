using System;
using System.Linq;

namespace P02._DungeonestDark
{
    class StartUp
    {
        static void Main()
        {
            string[] rooms = Console.ReadLine().Split('|').ToArray();
            int health = 100;
            int coins = 0;


            for (int i = 0; i < rooms.Length; i++)
            {
                string room = rooms[i];
                string[] roomSplited = room.Split();

                if (roomSplited[0] == "potion")
                {
                    int sizePotion = int.Parse(roomSplited[1]);
                    int currentHealth = health;
                    health += sizePotion;
                                        
                    if (health > 100)
                    {
                        health = 100;
                        Console.WriteLine($"You healed for {100 - currentHealth} hp.");
                        Console.WriteLine($"Current health: {100} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {sizePotion} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (roomSplited[0] == "chest")
                {
                    int foundedCoins = int.Parse(roomSplited[1]);
                    Console.WriteLine($"You found {foundedCoins} coins.");
                    coins += foundedCoins;
                }
                else
                {
                    string monster = roomSplited[0];
                    int powerOfMonster = int.Parse(roomSplited[1]);
                    health -= powerOfMonster;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i+1}");
                        break;
                    }
                }
                if (i == rooms.Length-1)
                {
                    Console.WriteLine("You've made it!");
                    Console.WriteLine($"Coins: {coins}");
                    Console.WriteLine($"Health: {health}");
                }
            }
        }
    }
}
