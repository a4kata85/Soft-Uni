namespace P04.BeverageLabels
{
    using System;
    class StartUp
    {
       public static void Main()
       {
            string nameFood = Console.ReadLine();
            int volumeFood = int.Parse(Console.ReadLine());
            int energyPerPart = int.Parse(Console.ReadLine());
            int sugarPerPart = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volumeFood}ml {nameFood}:");
            Console.WriteLine($"{volumeFood*energyPerPart/100.0}kcal, {volumeFood*sugarPerPart/100.0}g sugars");
       }
    }
}
