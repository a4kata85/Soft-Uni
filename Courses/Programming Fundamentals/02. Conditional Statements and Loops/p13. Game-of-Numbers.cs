namespace P13. GameOfNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            int firstNumber = 0;
            int secondNumber = 0;
            int counter = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (i+j == magicNumber)
                    {
                        sum = i + j;
                        firstNumber = i;
                        secondNumber = j;
                    }
                    else
                    {
                        counter++;
                    }
                }
            }
            if (firstNumber + secondNumber == magicNumber)
            {
                Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {magicNumber}");
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
            }


            
        }
    }
}
