using System;

namespace P07._LowerUpper
{
    class LowerUpper
    {
        static void Main()
        {
            char a = char.Parse(Console.ReadLine());

            if ((int)a > 96 && (int)a< 123)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
