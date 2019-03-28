using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P11._Letters_Change_Numbers
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?<firstLetter>[A-Za-z])(?<number>[\d]+)(?<lastLetter>[A-Za-z])";                        
            Regex order = new Regex(pattern);
            MatchCollection matches = order.Matches(input);

            char currentFirstChar = ' ';
            char currentSecondChar = ' ';
            char firstChar = ' ';
            char secondChar = ' ';
            int firstIndex = 0;
            int secondIndex = 0;
            double currentValue = 0.0;
            List<double> finalList = new List<double>();


            foreach (Match match in matches)
            {
                firstChar = char.Parse(match.Groups["firstLetter"].Value);
                secondChar = char.Parse(match.Groups["lastLetter"].Value);

                if (Char.IsUpper(firstChar))
                {
                    currentFirstChar = char.Parse(match.Groups["firstLetter"].Value);
                    firstIndex = char.ToUpper(currentFirstChar) - 64;
                    currentValue = int.Parse(match.Groups["number"].Value);
                    currentValue = currentValue/firstIndex;
                }
                else if (Char.IsLower(firstChar))
                {
                    currentFirstChar = char.Parse(match.Groups["firstLetter"].Value);
                    firstIndex = char.ToUpper(currentFirstChar) - 64;
                    currentValue = int.Parse(match.Groups["number"].Value);
                    currentValue = currentValue * firstIndex;

                }

                if (Char.IsUpper(secondChar))
                {
                    currentSecondChar = char.Parse(match.Groups["lastLetter"].Value);
                    secondIndex = char.ToUpper(currentSecondChar) - 64;
                    currentValue = currentValue - secondIndex;
                }
                else if (Char.IsLower(secondChar))
                {
                    currentSecondChar = char.Parse(match.Groups["lastLetter"].Value);
                    secondIndex = char.ToUpper(currentSecondChar) - 64;
                    currentValue = currentValue + secondIndex;
                }

                finalList.Add(currentValue);
            }
            double finalSum = finalList.Sum();
            Console.WriteLine($"{finalSum:f2}");
        }
    }
}
