using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.ReversingNumber
{
    class Program
    {
        public static void Main()
        {
            string input = (Console.ReadLine());
            string print = ReversingNumber(input);
            Console.WriteLine(print);
        }
        static string ReversingNumber (string number)
        {
            string reversed = "";
            for (int i = number.Length-1; i >= 0; i--)
            {
                reversed = reversed + number[i];
            }
            return reversed;
        }
    }
}
