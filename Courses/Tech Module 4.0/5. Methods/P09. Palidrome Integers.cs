using System;

namespace P09._PalindromeIntegers
{
    class StartUp
    {
        static void Main()
        {
            string numberAsString = Console.ReadLine();
            
            while (numberAsString != "END")
            {
                bool isPalid = IsPalidrome(numberAsString);
                Console.WriteLine(isPalid.ToString().ToLower());
                numberAsString = Console.ReadLine();
            }

        }

        public static bool IsPalidrome(string someString)
        {
            bool rezult = true;                       
                if (someString.Length % 2 == 1)
                {
                    for (int i = 0; i < someString.Length/2; i++)
                    {
                        if (someString[i] != someString[someString.Length-1-i])
                        {
                            rezult = false;
                            break;
                        }  
                    }
                }
                else
                {
                    for (int i = 0; i < someString.Length / 2; i++)
                    {
                        if (someString[i] != someString[someString.Length - 1 - i])
                        {
                            rezult = false;
                            break;
                        }
                    }
                }       
            return rezult;
        }
    }
}
