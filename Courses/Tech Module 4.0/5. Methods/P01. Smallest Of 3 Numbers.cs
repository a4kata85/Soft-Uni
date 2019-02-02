using System;

namespace P01._SmallestOf3Numbers
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int smallest = PrintSmallestNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(smallest);

        }

        public static int PrintSmallestNumber(int a, int b, int c)
        {
             
            int minOfFirstsNumbers = Math.Min(a, b);
            int minNumber = Math.Min(minOfFirstsNumbers, c);
            return minNumber;
        }
    }
}
