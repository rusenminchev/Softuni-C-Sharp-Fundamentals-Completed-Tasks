using System;

namespace MidExam___01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            byte empemployeeEfficiency1 = byte.Parse(Console.ReadLine());
            byte empemployeeEfficiency2 = byte.Parse(Console.ReadLine());
            byte empemployeeEfficiency3 = byte.Parse(Console.ReadLine());
            short studentsCount = short.Parse(Console.ReadLine());

            byte overallEfficiencyForOneHour = (byte)(empemployeeEfficiency1 + empemployeeEfficiency2 + empemployeeEfficiency3);
            byte hoursNeed = 0;


            while (studentsCount > 0)
            {
                hoursNeed++;
                if (hoursNeed % 4 == 0)
                {
                    hoursNeed++;
                }

                studentsCount -= overallEfficiencyForOneHour;
            }

            Console.WriteLine($"Time needed: {hoursNeed}h.");
        }
    }
}
