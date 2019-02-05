using System;
using System.Numerics;

namespace P08._FactorielDivision
{
    class StartUp
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            long firstFakt = Factorial(firstNumber);
            long secondFact = Factorial(secondNumber);

            Console.WriteLine($"{(double)firstFakt/secondFact:f2}");
        }

        private static long Factorial(int number)
        {
            long fakt = 1;
            for (int i = 2; i <= number; i++)
            {
                fakt = fakt * i;
            }
            return fakt;
        }
    }
}
