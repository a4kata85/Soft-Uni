namespace P13.VowelOrDigit
{
    using System;
    class StartUp
    {
        static void Main()
        {
            char whatsThis = char.Parse(Console.ReadLine());

            if (whatsThis == 'a' || whatsThis == 'e' || whatsThis == 'o' || whatsThis == 'i' || whatsThis == 'u' || whatsThis == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsNumber(whatsThis))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
