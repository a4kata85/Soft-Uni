using System;

namespace P02._VowelCount
{
    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int countVowels = CountVowels(text);
            Console.WriteLine(countVowels);
        }

        public static int CountVowels(string str)
        {
            int count = 0;
            char[] vowels = new char[] { 'a', 'o', 'u', 'e', 'i', 'A', 'O', 'U', 'E', 'I' };
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (str[i] == vowels[j])
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}
