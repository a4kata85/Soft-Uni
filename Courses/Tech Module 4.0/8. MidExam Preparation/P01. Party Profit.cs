using System;

namespace P01._PartyProfit
{
    class StartUp
    {
        static void Main()
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int totalCoins = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }
                totalCoins += 50;
                totalCoins = totalCoins - 2 * partySize;
                if (i % 3 == 0)
                {
                    totalCoins = totalCoins - 3 * partySize;
                }
                if (i % 5 == 0)
                {
                    totalCoins = totalCoins + 20 * partySize;
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        totalCoins = totalCoins - 2 * partySize;
                    }
                }
            }

            int coinsPerOneCompanion = (totalCoins / partySize);
            Console.WriteLine($"{partySize} companions received {coinsPerOneCompanion} coins each.");
        }
    }
}
