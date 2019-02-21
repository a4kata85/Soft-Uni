using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Students
{
    class StartUp
    {
        static void Main()
        {
            int countStudents = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            

            for (int i = 0; i < countStudents; i++)
            {
                string[] splitedInput = Console.ReadLine().Split();
                string firstName = splitedInput[0];
                string lastName = splitedInput[1];
                double grade = double.Parse(splitedInput[2]);
                Students student = new Students(firstName, lastName, grade);
                students.Add(student);
            }
            students = students.OrderByDescending(x => x.Grade).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} { student.LastName}: { student.Grade:f2}");
            }
        }
    }

    class Students
    {

        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public  string LastName { get; set; }
        public double Grade { get; set; }
    }
}
