namespace P04. VariableInHexadecimalFormat
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string hexDecimal = Console.ReadLine();
            int dec = Convert.ToInt32(hexDecimal, 16);

            Console.WriteLine(dec);
        }
    }
}
