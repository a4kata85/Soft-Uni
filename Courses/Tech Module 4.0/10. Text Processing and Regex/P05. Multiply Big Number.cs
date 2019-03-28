using System;
using System.Text;

namespace P05._Multiply_Big_Number
{
    class StartUp
    {
        static void Main()
        {
            string firstNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            string secondNumber = Console.ReadLine().TrimStart(new char[] { '0' });

            if (secondNumber == string.Empty)
            {
                Console.WriteLine(0);
                return;
            }

            byte sum = 0;
            byte numberInMined = 0;
            byte reminder = 0;

            StringBuilder result = new StringBuilder();

            for (int i = firstNumber.Length-1; i >= 0 ; i--)
            {
                for (int j = secondNumber.Length-1; j >= 0; j--)
                {
                    sum = (byte)(byte.Parse(firstNumber[i].ToString()) * byte.Parse(secondNumber[j].ToString()) + numberInMined);
                    numberInMined = (byte)(sum / 10);
                    reminder = (byte)(sum % 10);
                    result.Append(reminder);
                    if (i == 0 && numberInMined != 0)
                    {
                        result.Append(numberInMined);
                    }
                }
            }

            char[] resultToChar = result.ToString().ToCharArray();
            Array.Reverse(resultToChar);
            Console.WriteLine(new string(resultToChar));

        }
    }
}
