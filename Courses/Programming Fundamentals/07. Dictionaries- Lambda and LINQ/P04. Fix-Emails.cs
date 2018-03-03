using System;
using System.Linq;
using System.Collections.Generic;

namespace Demo
{
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, string> emailRegistar = new Dictionary<string, string>();
            string personName = Console.ReadLine();

            while (personName != "stop")
            {
                string email = Console.ReadLine();
                string domein = email.Substring(email.Length - 2).ToLower();

                if (domein != "uk" && domein != "us")
                {
                    emailRegistar[personName] = email;
                }

                personName = Console.ReadLine();
            }

            foreach (var item in emailRegistar)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
