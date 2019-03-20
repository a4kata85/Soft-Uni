using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Student_Academy
{
    class StartUp
    {
        static void Main()
        {
            int pairs = int.Parse(Console.ReadLine());

            var dataBase = new Dictionary<string, List<double>>();

            for (int i = 0; i < pairs; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());             

                if (!dataBase.ContainsKey(name))
                {
                    List<double> someGrade = new List<double>();
                    someGrade.Add(grade);
                    dataBase.Add(name, someGrade);
                }
                else
                {
                    dataBase[name].Add(grade);
                }
            }

            Dictionary<string, double> sortedDict = new Dictionary<string, double>();

            foreach (var kvp in dataBase)
            {
                if (kvp.Value.Average() >= 4.5)
                {
                    sortedDict.Add(kvp.Key, kvp.Value.Average());
                }
            }

            foreach (var kvp in sortedDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
}
