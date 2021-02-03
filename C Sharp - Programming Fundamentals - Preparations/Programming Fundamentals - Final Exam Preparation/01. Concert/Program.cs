using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> bandMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandPlayTime = new Dictionary<string, int>();


            while (command != "start of concert")
            {
                string[] tokens = command.Split("; ", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string band = tokens[1];

                if (action == "Add")
                {
                    string[] spllittedMemebers = tokens[2].Split(", ", StringSplitOptions.RemoveEmptyEntries);

                    if (!bandMembers.ContainsKey(band))
                    {
                        bandMembers.Add(band, new List<string>());

                        for (int i = 0; i < spllittedMemebers.Length; i++)
                        {

                            bandMembers[band].Add(spllittedMemebers[i]);

                        }
                    }
                    else
                    {
                        for (int i = 0; i < spllittedMemebers.Length; i++)
                        {
                            if (!bandMembers[band].Contains(spllittedMemebers[i]))
                            {
                                bandMembers[band].Add(spllittedMemebers[i]);
                            }
                        }
                    }
                }
                else if (action == "Play")
                {
                    int time = int.Parse(tokens[2]);

                    if (!bandPlayTime.ContainsKey(band))
                    {
                        bandPlayTime.Add(band, time);
                    }
                    else
                    {
                        bandPlayTime[band] += time;
                    }
                }


                command = Console.ReadLine();
            }

            int totalPlayTime = bandPlayTime.Values.Sum();

            Console.WriteLine($"Total time: {totalPlayTime}");

            bandPlayTime = bandPlayTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var band in bandPlayTime)
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            command = Console.ReadLine();
            Console.WriteLine(command);
            for (int i = 0; i < bandMembers[command].Count; i++)
            {
                Console.WriteLine($"=> {bandMembers[command][i]}");
            }
        }
    }
}
