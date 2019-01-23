using System;

namespace P10.Rage_Expenses
{
    class RageExpenses
    {
        static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headSetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int countHeadSets = lostGames / 2;
            int countMouses = lostGames / 3;
            int countKeyboards = lostGames/6;
            int countDisplays = lostGames / 12;

            decimal moneyNeeded = headSetPrice * countHeadSets + mousePrice * countMouses + 
                                  keyboardPrice * countKeyboards + displayPrice * countDisplays;

            Console.WriteLine("Rage expenses: {0:f2} lv.", moneyNeeded);
        }
    }
}
