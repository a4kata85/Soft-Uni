using System;

namespace P03._Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string kindGroup = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();

            double totalPrice = 0;

            if (kindGroup == "students")
            {
                if (dayOfWeek == "friday")
                {
                    totalPrice = 8.45 * countPeople;
                }
                else if (dayOfWeek == "saturday")
                {
                    totalPrice = 9.80 * countPeople;
                }
                else
                {
                    totalPrice = 10.46 * countPeople;
                }
                if (countPeople >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (kindGroup == "business")
            {
                if (countPeople>= 100)
                {
                    countPeople -= 10;
                }
                if (dayOfWeek == "friday")
                {
                    totalPrice = 10.90 * countPeople;
                }
                else if (dayOfWeek == "saturday")
                {
                    totalPrice = 15.60 * countPeople;
                }
                else
                {
                    totalPrice = 16.00 * countPeople;
                }
                
            }
            else
            {
                if (dayOfWeek == "friday")
                {
                    totalPrice = 15.00 * countPeople;
                }
                else if (dayOfWeek == "saturday")
                {
                    totalPrice = 20.00 * countPeople;
                }
                else
                {
                    totalPrice = 22.50 * countPeople;
                }
                if (countPeople >= 10 && countPeople <=20)
                {
                    totalPrice *= 0.95;
                }
            }

            Console.WriteLine("Total price: {0:f2}", totalPrice);
        }
    }
}
