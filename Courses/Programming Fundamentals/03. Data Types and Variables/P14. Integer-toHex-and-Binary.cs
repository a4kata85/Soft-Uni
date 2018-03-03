using System;
namespace P14.IntegerToHexAndBinary
{
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string hex = Convert.ToString(number, 16).ToUpper();
            string binary = Convert.ToString(number, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
