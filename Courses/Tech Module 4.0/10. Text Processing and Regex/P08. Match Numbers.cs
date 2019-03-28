using System;
using System.Text.RegularExpressions;

namespace P08._Match_Numbers
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(^|(?<=\s))-?[0-9]+(\.[0-9]+)?($|(?=\s))");

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }
            Console.WriteLine();
        }
    }
}
