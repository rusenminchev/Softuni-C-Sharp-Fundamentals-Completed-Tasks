using System;
using System.IO;
using System.Xml.Schema;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double totalMoney = 0;
            

            while (command != "End")
            {
                double productPrice = 0;

                while (command != "Start")
                {

                    if (double.Parse(command) == 2)
                    {
                        totalMoney += double.Parse(command);
                    }
                    else if (double.Parse(command) == 1)
                    {
                        totalMoney += double.Parse(command);
                    }
                    else if (double.Parse(command) == 0.5)
                    {
                        totalMoney += double.Parse(command);
                    }
                    else if (double.Parse(command) == 0.2)
                    {
                        totalMoney += double.Parse(command);
                    }
                    else if (double.Parse(command) == 0.1)
                    {
                        totalMoney += double.Parse(command);
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {double.Parse(command)}");
                    }
                    command = Console.ReadLine();

                }

                command = Console.ReadLine();


                if (command == "Nuts")
                {
                    totalMoney -= 2;
                }
                else if (command == "Water")
                {
                    totalMoney -= 0.7;
                }
                else if (command == "Crisps")
                {
                    totalMoney -= 1.5;
                }
                else if (command == "Soda")
                {
                    totalMoney -= 0.8;
                }
                else if (command == "Coke")
                {
                    totalMoney -= 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product.");
                }
                if (totalMoney <= 0)
                {
                    Console.WriteLine("Sorry, not enough money.");
                }
                else if (totalMoney > 0)
                {
                    Console.WriteLine($"Purchased {command}.");
                }
            }
        }
    }
}
