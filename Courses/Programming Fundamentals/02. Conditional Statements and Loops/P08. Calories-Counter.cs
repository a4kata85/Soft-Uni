namespace P08. CaloriesCounter
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int calCheese = 500;
            int calTomatoSauce = 150;
            int calSalami = 600;
            int calPepper = 50;

            int numberIngredient = int.Parse(Console.ReadLine());
            int sumCalories = 0;

            for (int i = 0; i < numberIngredient; i++)
            {
                string kindIngredient = Console.ReadLine().ToLower();
                if (kindIngredient == "cheese")
                {
                    sumCalories += calCheese;
                }
                else if (kindIngredient == "tomato sauce")
                {
                    sumCalories += calTomatoSauce;
                }
                else if (kindIngredient == "salami")
                {
                    sumCalories += calSalami; 
                }
                else if (kindIngredient == "pepper")
                {
                    sumCalories += calPepper;
                }
            }
            Console.WriteLine("Total calories: {0}", sumCalories);
        }
    }
}
