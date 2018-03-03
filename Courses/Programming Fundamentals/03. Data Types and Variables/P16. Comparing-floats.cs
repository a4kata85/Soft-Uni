namespace P16.ComparingFloats
{
    using System;
    class Program
    {
        static void Main()
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            if (Math.Abs(numberA - numberB) < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
