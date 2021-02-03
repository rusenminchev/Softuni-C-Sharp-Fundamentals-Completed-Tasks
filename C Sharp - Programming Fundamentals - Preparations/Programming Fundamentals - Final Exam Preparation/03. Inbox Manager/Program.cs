using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> usersEmailsInfo = new Dictionary<string, List<string>>();

            while (command != "Statistics")
            {
                string[] tokens = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];

                if (action == "Add")
                {
                    string username = tokens[1];
                    if (usersEmailsInfo.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    else
                    {
                        usersEmailsInfo.Add(username, new List<string>());
                    }

                }
                else if (action == "Send")
                {
                    string username = tokens[1];
                    string email = tokens[2];

                    usersEmailsInfo[username].Add(email);

                }
                else if (action == "Delete")
                {
                    string username = tokens[1];

                    if (usersEmailsInfo.ContainsKey(username))
                    {

                        usersEmailsInfo.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }

                command = Console.ReadLine();
            }

            usersEmailsInfo = usersEmailsInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Users count: {usersEmailsInfo.Count}");
            foreach (var user in usersEmailsInfo)
            {
                Console.WriteLine(user.Key);
                for (int i = 0; i < user.Value.Count; i++)
                {
                    Console.WriteLine($"- {user.Value[i]}");
                }
            }
        }
    }
}
