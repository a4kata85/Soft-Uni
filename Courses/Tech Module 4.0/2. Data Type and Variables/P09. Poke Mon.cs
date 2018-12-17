using System;

namespace P09._PokeMon
{
    class StartUp
    {
        static void Main()
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionY = int.Parse(Console.ReadLine());

            int tempPowerN = powerN;
            int targets = 0;

            while (tempPowerN >= distanceM)
            {
                tempPowerN -= distanceM;
                targets++;

                if (0.5 * powerN == tempPowerN && exhaustionY > 0)
                {
                    tempPowerN /= exhaustionY;
                }
            }          

            Console.WriteLine(tempPowerN);
            Console.WriteLine(targets);
        }
    }
}
