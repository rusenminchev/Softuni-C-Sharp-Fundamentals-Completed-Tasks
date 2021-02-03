using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentInfo = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
               
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentInfo.ContainsKey(name))
                {
                    studentInfo[name].Add(grade);
                }
                else
                {
                    studentInfo.Add(name, new List<double> { grade });
                }
            }

            studentInfo = studentInfo.OrderByDescending(x => x.Value.Average()).ToDictionary(a => a.Key, a => a.Value);

            foreach (var student in studentInfo)
            {

                if (student.Value.Average() <= 4.50)
                {
                    studentInfo.Remove(student.Key);

                }

                Console.WriteLine($"{student.Key} -> {student.Value.Average()}");
            }

        }
    }
}
