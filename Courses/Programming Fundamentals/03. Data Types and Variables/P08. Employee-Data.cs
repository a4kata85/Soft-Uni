namespace P08. EmployeeData
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong personalIdNumber = ulong.Parse(Console.ReadLine());
            int uniqueNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalIdNumber);
            Console.WriteLine("Unique Employee number: {0}", uniqueNumber);
        }
    }
}
