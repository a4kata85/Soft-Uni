using System;
using System.Linq;

namespace P01._EncryptSortPrint
{
    class StartUP
    {
        static void Main()
        {
            int countNames = int.Parse(Console.ReadLine());
            int currentSum = 0;           
            int[] finalArr = new int[countNames];


            for (int i = 0; i < countNames; i++)
            {
                string name = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < name.Length; j++)
                {                   
                    int currentSign = (int)name[j];
                    if (currentSign == 65 || currentSign == 69 || currentSign == 79 || currentSign == 73 
                        || currentSign == 85 || currentSign == 97 || currentSign == 101
                        || currentSign == 105 || currentSign == 111 || currentSign == 117)
                    {
                        currentSign *= name.Length;
                    }
                    else
                    {
                        currentSign /= name.Length;
                    }
                    currentSum += currentSign;
                    if (j == name.Length - 1)
                    {
                        sum = currentSum;
                        currentSum = 0;
                    }
                }
                finalArr[i] = sum;
            }
            Array.Sort(finalArr);
            foreach (var sums in finalArr)
            {
                Console.WriteLine(sums);
            }
            
        }
    }
}
