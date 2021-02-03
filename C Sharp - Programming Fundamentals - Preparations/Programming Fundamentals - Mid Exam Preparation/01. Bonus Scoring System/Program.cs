using System;

namespace CsharpFund___Exam_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            //{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})//

            byte studnetsCount = byte.Parse(Console.ReadLine());
            byte lecturesCount = byte.Parse(Console.ReadLine());
            byte additionalBonus = byte.Parse(Console.ReadLine());

            double totalBonus = 0;
            double maxBonus = 0;
            byte maxAttendances = 0;

            for (int i = 0; i < studnetsCount; i++)
            {
                byte attendancesOfEachStudent = byte.Parse(Console.ReadLine());

                totalBonus = (attendancesOfEachStudent * 1.0 / lecturesCount) * (5 + additionalBonus);
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendances = attendancesOfEachStudent;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");

        }
    }
}
