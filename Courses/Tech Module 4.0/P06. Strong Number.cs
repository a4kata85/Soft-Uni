using System;

namespace P06._StrongNumber
{
    class StrongNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int changingNumber = number;
            int fact = 1;
            int sumFact = 0;

            while (changingNumber != 0)
            {
                int currentNumber = changingNumber % 10;
                
                for (int i = 1; i<=currentNumber; i++)
                {                
                    fact = fact * i;
                }
                sumFact += fact;
                fact = 1;
                changingNumber /= 10;
            }

            if (sumFact == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
