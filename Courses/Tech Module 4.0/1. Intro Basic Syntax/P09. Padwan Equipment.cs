using System;

namespace P09.Padawan_Equipment
{
    class PadawanEquipment
    {
        static void Main()
        {
            decimal moneyIvanCho = decimal.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            decimal priceSingleSabre = decimal.Parse(Console.ReadLine()); // 10% more rounded....
            decimal priceSingleRobe = decimal.Parse(Console.ReadLine()); // const
            decimal priceSingleBelt = decimal.Parse(Console.ReadLine());  // every sixth belt free

            int countSabres = (int)(Math.Ceiling(countStudents * 1.10));
            int freeBelts = 0;
            if (countStudents>5)
            {
                freeBelts = countStudents / 6;
            }
            int countBelts = countStudents - freeBelts;

            decimal totalMoneyNeeded = countSabres * priceSingleSabre + priceSingleRobe * countStudents + countBelts * priceSingleBelt;

            if (totalMoneyNeeded <= moneyIvanCho)
            {
                Console.WriteLine("The money is enough - it would cost {0:f2}lv.", totalMoneyNeeded);
            }
            else
            {
                Console.WriteLine("Ivan Cho will need {0:f2}lv more.", totalMoneyNeeded-moneyIvanCho);
            }
        }
    }
}
