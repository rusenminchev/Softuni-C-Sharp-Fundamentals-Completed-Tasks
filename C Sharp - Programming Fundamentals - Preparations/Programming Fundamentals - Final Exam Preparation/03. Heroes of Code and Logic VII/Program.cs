using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{

    class Hero
    {
        public int HP { get; set; }
        public int MP { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string heroName = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);

                Hero hero = new Hero() { HP = hp, MP = mp };
                heroes.Add(heroName, hero);



            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command.Contains("CastSpell"))
                {
                    string[] splitted = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string heroName = splitted[1];
                    int mpNeeded = int.Parse(splitted[2]);
                    string spellName = splitted[3];

                    

                    if (heroes[heroName].MP - mpNeeded >= 0)
                    {
                        heroes[heroName].MP -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }

                }
                if (command.Contains("TakeDamage"))
                {
                    string[] splitted = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string heroName = splitted[1];
                    int damage = int.Parse(splitted[2]);
                    string attacker = splitted[3];

                    if (heroes[heroName].HP - damage > 0)
                    {
                        heroes[heroName].HP -= damage;
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HP} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                }
                if (command.Contains("Recharge"))
                {
                    string[] splitted = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string heroName = splitted[1];
                    int mpRecharged = int.Parse(splitted[2]);


                    if (heroes[heroName].MP + mpRecharged > 200)
                    {
                        mpRecharged = 200 - heroes[heroName].MP;
                    }

                    heroes[heroName].MP += mpRecharged;
                    Console.WriteLine($"{heroName} recharged for {mpRecharged} MP!");
                }
                if (command.Contains("Heal"))
                {
                    string[] splitted = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string heroName = splitted[1];
                    int hpHealed = int.Parse(splitted[2]);

                    if (heroes[heroName].HP + hpHealed > 100)
                    {
                        hpHealed = 100 - heroes[heroName].HP;
                    }
                    heroes[heroName].HP += hpHealed;
                    Console.WriteLine($"{heroName} healed for {hpHealed} HP!");
                }

                    command = Console.ReadLine();
            }

            foreach (var hero in heroes.OrderByDescending(x => x.Value.HP).ThenBy(x => x.Key))
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine("  HP: " + hero.Value.HP);
                Console.WriteLine("  MP: " + hero.Value.MP);
            }
        }
    }
}
