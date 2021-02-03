using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string username = input[1];

                if (command == "register")
                {
                    string licensePlate = input[2];
                    if (registeredUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        continue;
                    }
                    registeredUsers.Add(username, licensePlate);
                    Console.WriteLine($"{username} registered {licensePlate} successfully");
                }
                else if (command == "unregister")
                {
                    if (!registeredUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registeredUsers.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var registered in registeredUsers)
            {
                Console.WriteLine($"{registered.Key} => {registered.Value}");
            }
        }
    }
}
