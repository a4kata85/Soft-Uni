namespace P04.Hotel
{
    using System;
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceDouble;
            double priceSuite;

            double finalPriceStudio = 0;
            double finalPriceDouble = 0;
            double finalPriceSuite = 0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50.0;
                priceDouble = 65.0;
                priceSuite = 75.0;
                if (nights > 7)
                {
                    double discount = priceStudio * 0.05;
                    priceStudio -= discount;
                }
                finalPriceStudio = nights * priceStudio;
                finalPriceDouble = nights * priceDouble;
                finalPriceSuite = nights * priceSuite;

            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 60.0;
                priceDouble = 72.0;
                priceSuite = 82.0;

                if (nights > 14)
                {
                    double discount = priceDouble * 0.10;
                    priceDouble -= discount;
                }
                finalPriceStudio = (nights * priceStudio);
                finalPriceDouble = nights * priceDouble;
                finalPriceSuite = nights * priceSuite;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                priceStudio = 68.0;
                priceDouble = 77.0;
                priceSuite = 89.0;

                if (nights > 14)
                {
                    double discount = priceSuite * 0.15;
                    priceSuite -= discount;
                }

                finalPriceStudio = nights * priceStudio;
                finalPriceDouble = nights * priceDouble;
                finalPriceSuite = nights * priceSuite;
            }

            if ((month == "September" || month == "October") && nights > 7)
            {
                finalPriceStudio -= priceStudio;
            }

            Console.WriteLine("Studio: {0:f2} lv.", finalPriceStudio);
            Console.WriteLine("Double: {0:f2} lv.", finalPriceDouble);
            Console.WriteLine("Suite: {0:f2} lv.", finalPriceSuite);

        }
    }
