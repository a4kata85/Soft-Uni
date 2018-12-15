using System;

namespace P05._Login
{
    class Login
    {
        static void Main()
        {
            string login = Console.ReadLine();
            string passCorrect = "";

            for (int i = login.Length-1 ; i >= 0; i--)
            {
                passCorrect += login[i].ToString();
            }

            string somePass = Console.ReadLine();

            int tryCount = 0;

            while (somePass != passCorrect)
            {
                tryCount++;
                if (tryCount == 4)
                {
                    Console.WriteLine("User {0} blocked!", login);
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                somePass = Console.ReadLine();
            }
            if (somePass == passCorrect)
            {
                Console.WriteLine($"User {login} logged in.");
            }
            
        }
    }
}
