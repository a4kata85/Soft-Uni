namespace P03.RestaurantDiscount
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int groupNumber = int.Parse(Console.ReadLine());
            string packageKind = Console.ReadLine();

            double priceHall = 0.0;
            double packageNormal = 500.0;
            double packageGold = 750.0;
            double packagePlatinum = 1000.0;
         
            double packagePrice = 0;
            double personPrice = 0;

            string placeForStaying = "";

            switch (packageKind)
            {
                case "Normal":
                    if (groupNumber > 0 && groupNumber <= 50)
                    {
                        priceHall = 2500;
                        packagePrice = priceHall + packageNormal;
                        double discount = packagePrice * 0.05;
                        packagePrice -= discount;
                        personPrice = packagePrice / (double)groupNumber;
                        placeForStaying = "Small Hall";
                    }
                    else if (groupNumber > 50 && groupNumber <=100)
                    {
                        priceHall = 5000;
                        packagePrice = priceHall + packageNormal;
                        double discount = packagePrice * 0.05;
                        packagePrice -= discount;
                        personPrice = packagePrice / (double)groupNumber;
                        placeForStaying = "Terrace";
                    }
                    else if (groupNumber > 100 && groupNumber <= 120)
                    {
                        priceHall = 7500;
                        packagePrice = priceHall + packageNormal;
                        double discount = packagePrice * 0.05;
                        packagePrice -= discount;
                        personPrice = packagePrice / (double)groupNumber;
                        placeForStaying = "Great Hall";
                    }                  
                    break;
                case "Gold":
                    if (groupNumber > 0 && groupNumber <= 50)
                    {
                        priceHall = 2500;
                        packagePrice = priceHall + packageGold;
                        double discount = packagePrice * 0.10;
                        packagePrice -= discount;
                        personPrice = packagePrice / (double)groupNumber;
                        placeForStaying = "Small Hall";
                    }
                    else if (groupNumber > 50 && groupNumber <= 100)
                    {
                        priceHall = 5000;
                        packagePrice = priceHall + packageGold;
                        double discount = packagePrice * 0.10;
                        packagePrice -= discount;
                        personPrice = packagePrice / (double)groupNumber;
                        placeForStaying = "Terrace";
                    }
                    else if (groupNumber > 100 && groupNumber <= 120)
                    {
                        priceHall = 7500;
                        packagePrice = priceHall + packageGold;
                        double discount = packagePrice * 0.10;
                        packagePrice -= discount;
                        personPrice = packagePrice / (double)groupNumber;
                        placeForStaying = "Great Hall";
                    }
                    
                    break;
                case "Platinum":
                    if (groupNumber > 0 && groupNumber <= 50)
                    {
                        priceHall = 2500;
                        packagePrice = priceHall + packagePlatinum;
                        double discount = packagePrice * 0.15;
                        packagePrice -= discount;
                        personPrice = packagePrice / (double)groupNumber;
                        placeForStaying = "Small Hall";
                    }
                    else if (groupNumber > 50 && groupNumber <= 100)
                    {
                        priceHall = 5000;
                        packagePrice = priceHall + packagePlatinum;
                        double discount = packagePrice * 0.15;
                        packagePrice -= discount;
                        personPrice = packagePrice / (double)groupNumber;
                        placeForStaying = "Terrace";
                    }
                    else if (groupNumber > 100 && groupNumber <= 120)
                    {
                        priceHall = 7500;
                        packagePrice = priceHall + packagePlatinum;
                        double discount = packagePrice * 0.15;
                        packagePrice -= discount;
                        personPrice = packagePrice / (double)groupNumber;
                        placeForStaying = "Great Hall";
                    }                  
                    break;

                default:
                    break;
            }

            if (groupNumber >120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine("We can offer you the {0}", placeForStaying);
                Console.WriteLine("The price per person is {0:f2}$", personPrice);
            }
        }
    }
