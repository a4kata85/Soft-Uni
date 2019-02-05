using System;

namespace P06._MiddleCharacters
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string rezult = MiddleElement(input);
            Console.WriteLine(rezult);
        }

        public static string MiddleElement(string someString)
        {
            string rezult = string.Empty;
            if (someString.Length % 2 == 1)
            {
                rezult = someString[someString.Length / 2].ToString();
                return rezult;
            }
            else
            {
                string secondSymbol = someString[someString.Length / 2].ToString();
                string firstSymbol = someString[someString.Length / 2 - 1].ToString();
                rezult = firstSymbol + secondSymbol;
                return rezult;
            }
        }
    }
}
