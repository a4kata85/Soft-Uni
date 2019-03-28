using System;
using System.Text;

namespace P04._Ceaser_Cipher
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (var symbol in input)
            {
                char encryptedSymbol = (char)(symbol + 3);
                sb.Append(encryptedSymbol);
            }

            Console.WriteLine(sb);
        }
    }
}
