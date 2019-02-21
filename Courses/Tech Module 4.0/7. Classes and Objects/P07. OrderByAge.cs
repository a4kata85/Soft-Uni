using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._OrderByAge
{
    class StartUp
    {
        static void Main()
        {
            List<PersonInfo> colectionWithInfo = new List<PersonInfo>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                string[] splitedLine = line.Split();
                string name = splitedLine[0];
                string id = splitedLine[1];
                int age = int.Parse(splitedLine[2]);
                PersonInfo personInfo = new PersonInfo(name, id, age);
                colectionWithInfo.Add(personInfo);
            }

            colectionWithInfo = colectionWithInfo.OrderBy(x => x.Age).ToList();

            foreach (var person in colectionWithInfo)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }

        class PersonInfo
        {
            public PersonInfo(string name, string id, int age)
            {
                Name = name;
                Id = id;
                Age = age;
            }
            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }
        }
    }
}
