using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (output.ContainsKey(command))
                {
                    command += quantity;
                }
                else
                {
                    output.Add(command, quantity);
                }
            }

            foreach (var resourse in output)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }
        }
    }
}
