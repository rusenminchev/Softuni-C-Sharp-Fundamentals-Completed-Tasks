using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ").ToList();

            string regex = @"(?<dist1>\d*)(?<name>[A-Za-z]+)|(?<dist2>\d*)";

            Dictionary<string, int> racerInfo = new Dictionary<string, int>();

            foreach (var item in participants)
            {
                racerInfo.Add(item, 0);
            }

            string command = Console.ReadLine();
            string name = string.Empty;
            string digits = string.Empty;
            int distance = 0;

            while (command != "end of race")
            {
                MatchCollection matchingInput = Regex.Matches(command, regex);

                foreach (Match item in matchingInput)
                {
                    name += item.Groups["name"].Value;
                    digits += item.Groups["dist1"].Value;
                    digits += item.Groups["dist2"].Value;
                }
                for (int i = 0; i < digits.Length; i++)
                {
                    char currentDigit = digits[i];
                    distance += (int)(currentDigit - '0');
                }

                if (racerInfo.ContainsKey(name))
                {
                    racerInfo[name] += distance;
                }

                name = string.Empty;
                digits = string.Empty;
                distance = 0;
                command = Console.ReadLine();
            }

            racerInfo = racerInfo.OrderByDescending(x => x.Value).ToDictionary(a => a.Key, a => a.Value);
            int place = 1;

            foreach (var racer in racerInfo)
            {
                if (place == 1)
                {
                    Console.WriteLine($"{place}st place: {racer.Key}");
                }
                else if (place == 2)
                {
                    Console.WriteLine($"{place}nd place: {racer.Key}");
                }
                else if (place == 3)
                {
                    Console.WriteLine($"{place}rd place: {racer.Key}");
                }
                place++;
            }
        }
    }
}
