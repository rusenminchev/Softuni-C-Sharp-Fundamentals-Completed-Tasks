using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            int failCount = 0;

            string revUsername = new String(username.Reverse().ToArray());

            while (password != revUsername)
            {

                failCount++;
                if (failCount == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();

            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
