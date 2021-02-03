using System;

namespace Problem_1._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] tokens = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];

                if (action == "Move")
                {
                    int numberOfLetters = int.Parse(tokens[1]);

                    string substring = encryptedMessage.Substring(0, numberOfLetters);
                    encryptedMessage = encryptedMessage.Remove(0, numberOfLetters);
                    encryptedMessage += substring;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    string valueToInsert = tokens[2];

                    encryptedMessage = encryptedMessage.Insert(index, valueToInsert);

                }
                else if (action == "ChangeAll")
                {
                    string substring = tokens[1];
                    string replacement = tokens[2];

                    encryptedMessage = encryptedMessage.Replace(substring, replacement);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
