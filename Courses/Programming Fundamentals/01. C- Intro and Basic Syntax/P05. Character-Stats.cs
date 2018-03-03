namespace P05.CharacterStats
{
    using System;
    class StartUp
    {
        public static void Main()
        {
            string characterName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string health = "|" + new string('|', currentHealth) + new string('.', maxHealth - currentHealth) + "|";
            string energy = "|" + new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy) + "|";

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
