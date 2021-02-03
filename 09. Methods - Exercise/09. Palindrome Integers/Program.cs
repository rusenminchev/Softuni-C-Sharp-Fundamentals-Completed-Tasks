using System;
using System.Data;
using System.Security.Cryptography;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            PolidromeIntager(command);
        }

        static void PolidromeIntager(string command)
        {

            string reversedN1 = "";

            while (command != "END")
            {
                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reversedN1 += command[i];

                }
                if (int.Parse(command) == int.Parse(reversedN1))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();
                reversedN1 = "";
            }
        }
    }
}
