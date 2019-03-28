using System;
using System.Linq;

namespace P02._Character_Multiplier
{
    class StartUp
    {
        static void Main()
        {
            string[] tokens = Console.ReadLine().Split().ToArray();
            string firstWord = tokens[0];
            string secondWord = tokens[1];

            string longerWord = string.Empty;
            string shorterWord = string.Empty;

            int totalSum = 0;

            if (firstWord.Length >= secondWord.Length)
            {
                longerWord = firstWord;
                shorterWord = secondWord;
            }
            else
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }

            for (int i = 0; i < shorterWord.Length; i++)
            {
                totalSum += longerWord[i] * shorterWord[i];
            }

            for (int i = shorterWord.Length; i < longerWord.Length; i++)
            {
                totalSum += longerWord[i];
            }

            Console.WriteLine(totalSum);
        }
    }
}
