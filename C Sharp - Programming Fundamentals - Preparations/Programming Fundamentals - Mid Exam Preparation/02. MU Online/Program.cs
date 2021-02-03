using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            int health = 100;

            int bitcoin = 0;
            int healAmount = 0;

            int roomsCounter = 0;

            for (int i = 0; i < command.Length; i++)
            {
                roomsCounter++;

                string[] currentRoom = command[i].Split();

                if (currentRoom[0] == "potion")
                {
                    health += int.Parse(currentRoom[1]);
                    healAmount = int.Parse(currentRoom[1]);
                    if (health >= 100)
                    {
                        healAmount = 100 - (health - int.Parse(currentRoom[1]));
                        health = 100;
                    }

                    Console.WriteLine($"You healed for {healAmount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (currentRoom[0] == "chest")
                {
                    bitcoin += int.Parse(currentRoom[1]);
                    Console.WriteLine($"You found {currentRoom[1]} bitcoins.");
                }
                else
                {
                    health -= int.Parse(currentRoom[1]);
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {currentRoom[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {currentRoom[0]}.");
                        Console.WriteLine($"Best room: {roomsCounter}");
                        return;
                    }
                }

            }
            
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoin}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
