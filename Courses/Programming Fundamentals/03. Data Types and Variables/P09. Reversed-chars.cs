namespace P09.ReverseCharacters
{
    using System;
    class StartUp
    {    
        static void Main()
        {
            char[] arr = new char[3];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            Array.Reverse(arr);
            string str = new string(arr);
            Console.WriteLine(str);
        }
    }
}
