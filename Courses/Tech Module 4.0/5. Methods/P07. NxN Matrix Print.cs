using System;

namespace P07._NxNMatrix
{
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintMatrix(number);
        }

        public static void PrintMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
