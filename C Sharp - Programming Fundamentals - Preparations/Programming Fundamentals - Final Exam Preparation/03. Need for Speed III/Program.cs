using System;
using System.Collections.Generic;
using System.Linq;


namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Dictionary<string, List<int>> carInfo = new Dictionary<string, List<int>>();



            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

                List<int> carFuelAndMileage = new List<int>();
                carFuelAndMileage.Add(int.Parse(input[1]));
                carFuelAndMileage.Add(int.Parse(input[2]));
                carInfo.Add(input[0], carFuelAndMileage);
            }


            var command = Console.ReadLine();


            while (command != "Stop")
            {
                var commandsInput = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandsInput[0];
                if (action.Contains("Drive"))
                {
                    string car = commandsInput[1];
                    int distance = int.Parse(commandsInput[2]);
                    int fuel = int.Parse(commandsInput[3]);

                    if (carInfo[car][1] - fuel < 0)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carInfo[car][1] -= fuel;
                        carInfo[car][0] += distance;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                    }
                    if (carInfo[car][0] >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {car}!");
                        carInfo.Remove(car);

                    }
                }
                else if (action.Contains("Refuel"))
                {
                    string car = commandsInput[1];
                    int fuel = int.Parse(commandsInput[2]);
                    int neededFuel = fuel;
                    if (carInfo[car][1] + fuel > 75)
                    {
                        neededFuel = 75 - carInfo[car][1];
                        carInfo[car][1] = 75;
                        
                    }
                    else
                    {
                        carInfo[car][1] += fuel;
                    }

                    Console.WriteLine($"{car} refueled with {neededFuel} liters");
                }
                else if (action.Contains("Revert"))
                {
                    string car = commandsInput[1];
                    int kilometersToRevert = int.Parse(commandsInput[2]);

                    if (carInfo[car][0] - kilometersToRevert < 10000)
                    {
                        carInfo[car][0] = 10000;
                    }
                    else
                    {
                        carInfo[car][0] -= kilometersToRevert;
                        Console.WriteLine($"{car} mileage decreased by {kilometersToRevert} kilometers");

                    }
                }

                command = Console.ReadLine();
            }

            carInfo = carInfo.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(a => a.Key, a => a.Value);

            foreach (var car in carInfo)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}

                    