using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.IndexOfLetters
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            char[] sign = word.ToCharArray();

            for (int i = 0; i < sign.Length; i++)
            {
                Console.WriteLine(sign[i] + " -> " + (int)(sign[i]-97));
            }
        }
    }
}

