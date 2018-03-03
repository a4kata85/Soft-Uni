namespace P12. TestNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int product = 1;
            int tempSum = 0;
            int counter = 0;

            for (int i = n; i >= 1; i--)
            {
                if (tempSum >= maxSum)
                {
                    break;
                }
                for (int j = 1; j <= m; j++)
                {  
                    product = 3*(i * j);
                    tempSum = tempSum + product;
                    counter++;
                    if (tempSum >= maxSum)
                    {
                        break;
                    }  
                }
            }
            if (tempSum >= maxSum)
            {
                Console.WriteLine("{0} combinations", counter);
                Console.WriteLine("Sum: {0} >= {1}", tempSum, maxSum);
            }
            else
            {
                Console.WriteLine("{0} combinations", counter);
                Console.WriteLine("Sum: {0}", tempSum);
            }
            
        }
    }
}
