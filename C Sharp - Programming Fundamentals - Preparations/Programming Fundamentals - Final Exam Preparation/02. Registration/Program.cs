using System;
using System.Text.RegularExpressions;

namespace _02._Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"U\$([A-Z][a-z]{2,})U\$P@\$([a-z]{5,}\d+)P@\$");
            int n = int.Parse(Console.ReadLine());
            int successfulRegistrationsCount = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match validRegs = pattern.Match(input);

                if (validRegs.Success)
                {
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {validRegs.Groups[1]}, Password: {validRegs.Groups[2]}");
                    successfulRegistrationsCount++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }


            Console.WriteLine($"Successful registrations: {successfulRegistrationsCount}");

        }
    }
}
