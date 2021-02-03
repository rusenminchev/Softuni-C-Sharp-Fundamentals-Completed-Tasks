using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> citiesInfo = new Dictionary<string, Dictionary<string, int>>();

            while (command != "Sail")
            {
                string[] tokens = command.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string cityName = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                if (citiesInfo.ContainsKey(cityName))
                {
                    citiesInfo[cityName]["population"] += population;
                    citiesInfo[cityName]["gold"] += gold;
                }
                else
                {
                    citiesInfo.Add(cityName, new Dictionary<string, int>()
                {
                { "population", population },
                    {"gold", gold}
                });
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string cityName = tokens[1];

                if (action == "Plunder")
                {
                    int people = int.Parse(tokens[2]);
                    int gold = int.Parse(tokens[3]);

                    Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");
                    citiesInfo[cityName]["population"] -= people;
                    citiesInfo[cityName]["gold"] -= gold;

                    if (citiesInfo[cityName]["population"] <= 0 || citiesInfo[cityName]["gold"] <= 0)
                    {
                        Console.WriteLine($"{cityName} has been wiped off the map!");
                        citiesInfo.Remove(cityName);
                    }

                }
                else if (action == "Prosper")
                {
                    int gold = int.Parse(tokens[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        citiesInfo[cityName]["gold"] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {citiesInfo[cityName]["gold"]} gold.");
                    }
                }
                command = Console.ReadLine();
            }

            if (citiesInfo.Count > 0)
            {
                citiesInfo = citiesInfo.OrderByDescending(x => x.Value["gold"]).ThenBy(x => x.Key).ToDictionary(a => a.Key, a => a.Value);
                Console.WriteLine($" Ahoy, Captain! There are {citiesInfo.Count} wealthy settlements to go to:");
                foreach (var city in citiesInfo)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value["population"]} citizens, Gold: {city.Value["gold"]} kg");
                    
                }
            }
        }
    }
}
