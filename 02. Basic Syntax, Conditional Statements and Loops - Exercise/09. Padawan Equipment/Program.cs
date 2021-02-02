using System;
using System.Xml.Schema;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double totalCost = (studentsCount * lightsabers) + (studentsCount * robes) + (studentsCount * (belts));

            double freeBelts = (studentsCount / 6) * belts;
            double extraLightsabers = Math.Ceiling(studentsCount * 0.10);
            extraLightsabers = extraLightsabers * lightsabers;

            totalCost = (totalCost - freeBelts) + extraLightsabers;

            if (budget >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else if (totalCost > budget)
            {
                double moneyNeeded = totalCost - budget;
                Console.WriteLine($"Ivan Cho will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
