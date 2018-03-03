namespace P14. MagicLetter
{
    using System;
    class StartUp
    {
        static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            string invalidChar = Console.ReadLine();

            string rezult = "";

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        rezult = $"{i}{j}{k}";
                        if (!rezult.Contains(invalidChar))
                        {
                            Console.Write("{0} ", rezult);
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
