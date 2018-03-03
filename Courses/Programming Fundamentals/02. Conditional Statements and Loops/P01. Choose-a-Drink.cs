namespace P01.ChooseADrink
{
    using System;
    class StartUp
    {
        public static void Main()
        {
            string profession = Console.ReadLine().ToLower();
            if (profession == "athlete")
            {
                Console.WriteLine("Water");
            }
            else if (profession == "businessman" || profession == "businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (profession == "softuni student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
