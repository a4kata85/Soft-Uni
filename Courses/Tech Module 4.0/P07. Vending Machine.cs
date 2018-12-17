using System;

namespace P07._Vending_Machine
{
    class VendingMachine
    {
        static void Main()
        {
            string input = Console.ReadLine();
            decimal sumMoney = 0;

            while (input != "Start")
            {
                decimal coin = decimal.Parse(input);
                if (coin != 0.1m && coin != 0.2m && coin != 0.5m && coin != 1 && coin != 2)
                {
                    Console.WriteLine("Cannot accept {0}", coin);
                }
                else
                {
                    sumMoney += coin;
                }
                input = Console.ReadLine();
            }
            string inputItem = Console.ReadLine();
            while (inputItem != "End")
            {
                if (inputItem == "Nuts")
                {
                    if (sumMoney < 2.0m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased {0}", inputItem.ToLower());
                        sumMoney -= 2.0m;
                    }
                }
                else if (inputItem == "Water")
                {
                    if (sumMoney < 0.7m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased {0}", inputItem.ToLower());
                        sumMoney -= 0.7m;
                    }
                }
                else if (inputItem == "Crisps")
                {
                    if (sumMoney < 1.5m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased {0}", inputItem.ToLower());
                        sumMoney -= 1.5m;
                    }
                }
                else if (inputItem == "Soda")
                {
                    if (sumMoney < 0.8m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased {0}", inputItem.ToLower());
                        sumMoney -= 0.8m;
                    }
                }
                else if (inputItem == "Coke")
                {
                    if (sumMoney < 1.0m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased {0}", inputItem.ToLower());
                        sumMoney -= 1.0m;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                
                inputItem = Console.ReadLine();
            }

            Console.WriteLine("Change: {0:f2}", sumMoney);
        }
    }
}
