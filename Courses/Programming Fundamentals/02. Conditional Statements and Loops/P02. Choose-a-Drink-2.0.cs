namespace P02.ChooseADink_2._0
{
    using System;
    class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());

            double priceWater = 0.70;
            double priceCoffee = 1.00;
            double priceBeer = 1.70;
            double priceTea = 1.20;

            double totalPrice = 0;

            if (profession == "Athlete")
            {
                totalPrice = qty * priceWater;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                totalPrice = qty * priceCoffee;
            }
            else if (profession == "SoftUni Student")
            {
                totalPrice = qty * priceBeer;
            }
            else
            {
                totalPrice = qty *priceTea;
            }

            Console.WriteLine("The {0} has to pay {1:f2}.", profession, totalPrice);
        }
    }
}
