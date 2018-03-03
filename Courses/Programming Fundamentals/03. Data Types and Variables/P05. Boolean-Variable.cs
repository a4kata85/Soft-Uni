namespace P05. BooleanVariable
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string boolean = Console.ReadLine();
            bool yesNo = Convert.ToBoolean(boolean);
            if (yesNo == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
