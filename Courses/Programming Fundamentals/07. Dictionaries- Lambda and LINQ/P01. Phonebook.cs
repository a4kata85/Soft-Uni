using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.PhoneBook
{
    class StartUp
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, string> nameNumberDict = new Dictionary<string, string>();

            
           

            while (line[0] != "END")
            {
                var command = line[0];
                var name = line[1];
                if (line[0] == "A")
                {
                    var number = line[2];
                    if (nameNumberDict.ContainsKey(name))
                    {
                        nameNumberDict.Remove(name);
                    }
                    nameNumberDict.Add(name, number);
                }

                else if (line[0] == "S")
                {
                    if (nameNumberDict.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, nameNumberDict[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }
               line = Console.ReadLine().Split(' ');
            }
        }
    }
}
