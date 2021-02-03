using System;

namespace _09.Greater_of_Two_Values_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {

                int v1 = int.Parse(Console.ReadLine());
                int v2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetGreater(v1, v2));

            }

            if (type == "char")
            {

                char v1 = char.Parse(Console.ReadLine());
                char v2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetGreater(v1, v2));

            }

            if (type == "string")
            {
                string v1 = Console.ReadLine();
                string v2 = Console.ReadLine();
                Console.WriteLine(GetGreater(v1, v2));

            }
        }

        static int GetGreater(int v1, int v2)
        {
            int compare = v1.CompareTo(v2);

            if (compare > 0)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }

        static char GetGreater(char v1, char v2)
        {
            int compare = v1.CompareTo(v2);

            if (compare > 0)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }

        static string GetGreater(string v1, string v2)
        {
            int compare = v1.CompareTo(v2);

            if (compare > 0)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }
    }
}
