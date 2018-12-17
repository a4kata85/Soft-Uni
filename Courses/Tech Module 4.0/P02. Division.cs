using System;

namespace P02._Division
{
    class Division
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int div = 0;

            if (n%2 == 0)
            {
                div = 2;
            }
            if (n % 3 == 0)
            {
                div = 3;
            }
            if (n % 6 == 0)
            {
                div = 6;
            }
            if (n % 7 == 0)
            {
                div = 7;
            }
            if (n % 10 == 0)
            {
                div = 10;
            }

            if (div == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine("The number is divisible by {0}", div);
            }
        }
    }
}
