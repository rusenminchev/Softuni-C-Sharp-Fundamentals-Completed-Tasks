using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> courseInfoOrdered = new Dictionary<string, List<string>>();
            int count = 0;


            while (true)
            {
                List<string> input = Console.ReadLine().Split(" : ").ToList();
                string courseName = input[0];
                if (courseName == "end")
                {
                    break;
                }
                string studentName = input[1];

                if (courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName].Add(studentName);
                }
                else
                {
                    courseInfo.Add(courseName, new List<string> { studentName });
                }
            }

            // !!! ВАЖНО! Полезно за сортиране с ламбда изрази !!! 
            courseInfo = courseInfo.OrderByDescending(x => x.Value.Count).ToDictionary(a => a.Key, a => a.Value);
            
            foreach (var course in courseInfo)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                for (int i = 0; i < course.Value.Count; i++)
                {
                    course.Value.Sort();
                    Console.WriteLine($"-- " + course.Value[i]);
                }

            }
        }
    }
}
