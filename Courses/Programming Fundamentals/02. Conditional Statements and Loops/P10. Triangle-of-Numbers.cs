namespace P10. TriangleOfNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("{0} ", row);                   
                }
                Console.WriteLine();
            }
        }
    }
}
