using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            string greater = GetMax(type, value1, value2);

            Console.WriteLine(greater);
        }

        static string GetMax(string type, string v1, string v2)
        {
            var greater = "";

            switch (type)
            {
                case "int":
      
                    if (int.Parse(v1) > int.Parse(v2))
                    {
                        greater = v1;
                    }
                    if (int.Parse(v2) > int.Parse(v1))
                    {
                        greater = v2;
                    }

                    break;

                case "char":

                    if (char.Parse(v1) > char.Parse(v2))
                    {
                        greater = v1;
                    }
                    else if (char.Parse(v2) > char.Parse(v1))
                        {
                            greater = v2;
                        }

                    break;

                case "string":

                    char[] splitted = v1.ToCharArray();
                    char[] splitted2 = v2.ToCharArray();
                    int charSum1 = 0;
                    int charSum2 = 0;


                    for (int i = 0; i < splitted.Length; i++)
                    {
                        charSum1 += splitted[i];
                    }

                    for (int i = 0; i < splitted2.Length; i++)
                    {
                        charSum2 += splitted2[i];
                    }

                    if (charSum1 > charSum2)
                    {
                        greater = v1;
                    }
                    else if (charSum2 > charSum1)
                    {
                        greater = v2;
                    }
                    break;
            }

            return greater;
        }
    }
}
