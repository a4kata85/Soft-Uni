namespace P11. DifferentNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (Math.Abs(a-b)<5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int d1 = a; d1 <= b; d1++)
                {
                    for (int d2 = a; d2 <= b; d2++)
                    {
                        for (int d3 = a; d3 <= b; d3++)
                        {
                            for (int d4 = a; d4 <= b; d4++)
                            {
                                for (int d5 = a; d5 <= b; d5++)
                                {
                                    if (d1 < d2 && d2 < d3 && d3 < d4 && d4 < d5)
                                    {
                                        Console.Write("{0} {1} {2} {3} {4}", d1, d2, d3, d4, d5);
                                        Console.WriteLine();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
