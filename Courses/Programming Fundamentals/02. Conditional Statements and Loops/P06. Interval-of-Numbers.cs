namespace P06. IntervalOfNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int smallerNumber = Math.Min(firstNumber, secondNumber);
            int biggerNumber = Math.Max(firstNumber, secondNumber);

            for (int i = smallerNumber; i <= biggerNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
