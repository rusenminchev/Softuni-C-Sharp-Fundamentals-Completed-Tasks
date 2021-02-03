using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            Dictionary<string, List<string>> guestsFeedback = new Dictionary<string, List<string>>();

            int unlikedMealsCount = 0;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] tokens = command.Split('-', StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string guest = tokens[1];
                string meal = tokens[2];

                if (action == "Like")
                {
                    if (guestsFeedback.ContainsKey(guest))
                    {
                        if (!guestsFeedback[guest].Contains(meal))
                        {
                            guestsFeedback[guest].Add(meal);
                        }
                    }
                    else
                    {
                        guestsFeedback.Add(guest, new List<string>());
                        guestsFeedback[guest].Add(meal);
                    }

                }
                else if (action == "Unlike")
                {
                    if (!guestsFeedback.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (!guestsFeedback[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {
                        guestsFeedback[guest].Remove(meal);
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        unlikedMealsCount++;
                    }
                }
            }

            guestsFeedback = guestsFeedback.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var guest in guestsFeedback)
            {

                Console.WriteLine($"{guest.Key}: " + String.Join(", ", guest.Value));

            }

            Console.WriteLine($"Unliked meals: {unlikedMealsCount}");

        }
    }
}
