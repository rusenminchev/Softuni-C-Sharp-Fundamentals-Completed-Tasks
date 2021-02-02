using System;

namespace _03._Vacancion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double pricePerNightPerPerson = 0;
            double totalPrice = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    
                    switch (dayOfTheWeek)
                    {
                        case "Friday":
                            pricePerNightPerPerson = 8.45;
                            break;

                        case "Saturday":
                            pricePerNightPerPerson = 9.80;
                            break;

                        case "Sunday":
                            pricePerNightPerPerson = 10.46;
                            break;
                    }

                    totalPrice = numOfPeople * pricePerNightPerPerson;

                    if (numOfPeople >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");

                    break;

                case "Business":

                    switch (dayOfTheWeek)
                    {
                        case "Friday":
                            pricePerNightPerPerson = 10.90;
                            break;

                        case "Saturday":
                            pricePerNightPerPerson = 15.60;
                            break;

                        case "Sunday":
                            pricePerNightPerPerson = 16;
                            break;
                    }

                    totalPrice = numOfPeople * pricePerNightPerPerson;

                    if (numOfPeople >= 100)
                    {
                        totalPrice -= (10 * pricePerNightPerPerson);
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");

                    break;

                case "Regular":

                    switch (dayOfTheWeek)
                    {
                        case "Friday":
                            pricePerNightPerPerson = 15;
                            break;

                        case "Saturday":
                            pricePerNightPerPerson = 20;
                            break;

                        case "Sunday":
                            pricePerNightPerPerson = 22.50;
                            break;       
                    }

                    totalPrice = numOfPeople * pricePerNightPerPerson;

                    if (numOfPeople >= 10 && numOfPeople <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");

                    break;
            }
        }
    }
}
