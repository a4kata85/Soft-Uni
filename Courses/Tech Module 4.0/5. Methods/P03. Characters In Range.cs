using System;

namespace P03._CharactersInRange
{
    class StartUp
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            Console.WriteLine(CharsBetweenTwoChars(firstChar, secondChar));


        }

        public static string CharsBetweenTwoChars(char a, char b)
        {
            string rezult = string.Empty;
            if ((char)a < (char)b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    rezult += (char)i + " ";
                }
                return rezult;
            }
            else
            {
                for (int i = b+1; i < a; i++)
                {
                    rezult += (char)i + " ";
                }
                return rezult;
            }
        }
    }
}
