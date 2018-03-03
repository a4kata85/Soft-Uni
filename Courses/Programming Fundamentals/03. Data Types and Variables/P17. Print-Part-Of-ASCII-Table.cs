namespace P17.PrintPartASCIITable
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                Console.Write("{0} ", Convert.ToChar(i));
            }
            Console.WriteLine();
        }
    }
}
