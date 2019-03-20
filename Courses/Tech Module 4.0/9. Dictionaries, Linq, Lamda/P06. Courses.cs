using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Courses
{
    class StartUp
    {
        static void Main()
        {
            var coursesStudents = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] splitedLine = line.Split(" : ");
                string course = splitedLine[0];
                string name = splitedLine[1];

                if (!coursesStudents.ContainsKey(course))
                {
                    List<string> students = new List<string>();
                    students.Add(name);
                    coursesStudents.Add(course, students);
                }
                else
                {
                    coursesStudents[course].Add(name);
                }               
            }

            var dict = coursesStudents.OrderByDescending(x => x.Value.Count);

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                var orderStudents = kvp.Value.OrderBy(x => x).ToList();
                foreach (var student in orderStudents)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
