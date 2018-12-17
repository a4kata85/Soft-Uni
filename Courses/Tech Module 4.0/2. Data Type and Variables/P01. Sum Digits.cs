using System;

namespace P01._Sum_Digits
{
    class SumDigits
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sumDigits = 0;

            while (number != 0)
            {
                int tempLastDigit = number % 10;
                sumDigits += tempLastDigit;
                number /= 10;
            }
            Console.WriteLine(sumDigits);
        }
    }
}
