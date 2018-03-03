namespace P06. StringsAndObjects
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string firstString = "Hello";
            string secondString = "World";
            object together = firstString + " " + secondString;

            
            Console.WriteLine(together);
        }
    }
}
