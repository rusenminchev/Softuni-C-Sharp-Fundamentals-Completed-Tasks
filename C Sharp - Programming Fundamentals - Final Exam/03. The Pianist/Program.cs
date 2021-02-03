using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{

    class ComposerKey
    {
        public string Composer { get; set; }
        public string Key { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, ComposerKey> pianistInfo = new Dictionary<string, ComposerKey>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|');
                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                ComposerKey composerKey = new ComposerKey() { Composer = composer, Key = key };

                pianistInfo.Add(piece, composerKey);
            }

            string commands = Console.ReadLine();

            while (commands != "Stop")
            {
                string[] tokens = commands.Split('|');
                string action = tokens[0];


                if (action == "Add")
                {
                    string piece = tokens[1];
                    string composer = tokens[2];
                    string key = tokens[3];

                    if (pianistInfo.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        pianistInfo.Add(piece, new ComposerKey() { Composer = composer, Key = key });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    string piece = tokens[1];

                    if (pianistInfo.ContainsKey(piece))
                    {
                        pianistInfo.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }

                }
                else if (action == "ChangeKey")
                {

                    string piece = tokens[1];
                    string newKey = tokens[2];

                    if (pianistInfo.ContainsKey(piece))
                    {
                        pianistInfo[piece].Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                commands = Console.ReadLine();
            }

            pianistInfo = pianistInfo.OrderBy(x => x.Key).ThenBy(x => x.Value.Composer).ToDictionary(x => x.Key, x => x.Value);


            foreach (var item in pianistInfo)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value.Composer}, Key: {item.Value.Key}");
            }

        }
    }
}
