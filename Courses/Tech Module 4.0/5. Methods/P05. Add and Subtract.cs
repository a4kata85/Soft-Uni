using System;

namespace P05._AddAndSubtract
{
    class StartUp
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int sum = Sum(firstNumber, secondNumber);
            int subtract = Subtract(sum, thirdNumber);
            Console.WriteLine(subtract);
        }

        public static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        public static int Subtract(int a, int b)
        {
            int subtract = a - b;
            return subtract;
        }
    }
}
