using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool invalid = false;
            if (CountTheNumberOfCharacters(password) < 6 || CountTheNumberOfCharacters(password) > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;
            }
            if (IsItConsistsOnlyLettersAndDigits(password) > 0)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalid = true;
            }
            if (IsItContainsAtLeast2Digits(password) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }
            if (invalid == false)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static int CountTheNumberOfCharacters(string password)
        {
            int charsCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                charsCounter++;
            }
                return charsCounter;
        }

        static int IsItConsistsOnlyLettersAndDigits(string password)
        {
            bool valid = true;
            int otherSymbolsCount = 0;

            for (int i = 0; i < password.Length; i++)
            {
                valid = char.IsLetterOrDigit(password[i]);
                if (valid == false)
                {
                    otherSymbolsCount++;
                    break;
                }
            }

            return otherSymbolsCount;
        }

        static int IsItContainsAtLeast2Digits(string password)
        {
            int digitsCounter = 0;
            bool IsDigit = false;


            for (int i = 0; i < password.Length; i++)
            {
                IsDigit = char.IsDigit(password[i]);
                if (IsDigit == true)
                {
                    digitsCounter++;
                }
                IsDigit = false;
            }

            return digitsCounter;
        }

    }
}
