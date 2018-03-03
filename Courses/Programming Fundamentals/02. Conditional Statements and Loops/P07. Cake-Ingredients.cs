amespace P07. CakeIngredients
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int countIngredients = 0;
            for (int i = 1; i <= 20; i++)
            {
                string ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    break;
                }
                else
                {
                    countIngredients++;
                }
                Console.WriteLine("Adding ingredient {0}.", ingredient);
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", countIngredients);
        }
    }
}
