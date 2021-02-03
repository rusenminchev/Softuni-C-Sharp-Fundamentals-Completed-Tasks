using System;
using System.Linq;
using System.Text;

namespace Exam_prep
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {

                if (command.Contains("TakeOdd"))
                {
                    StringBuilder oddChars = new StringBuilder();
                    for (int i = 1; i < password.Length; i += 2)
                    {
                        oddChars.Append(password[i]);
                    }
                    password = oddChars.ToString();
                    Console.WriteLine(password);
                }

                if (command.Contains("Cut"))
                {
                    string[] splitted = command.Split();
                    int index = int.Parse(splitted[1]);
                    int lenght = int.Parse(splitted[2]);

                    password = password.Remove(index, lenght); 

                    Console.WriteLine(password);
                }
                if (command.Contains("Substitute"))
                {
                    string[] splitted = command.Split();
                    string substring = splitted[1];
                    string substitute = splitted[2];

                    if (password.IndexOf(substring) >= 0)
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
