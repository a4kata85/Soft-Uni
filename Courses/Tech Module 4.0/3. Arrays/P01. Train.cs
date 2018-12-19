using System;

namespace P01._Train
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];
            int sumPeople = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sumPeople += wagons[i];
            }

            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(sumPeople);
        }
    }
}
