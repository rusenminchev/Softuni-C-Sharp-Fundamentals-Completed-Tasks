using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();

            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            string legendaryItem = string.Empty;
            bool isLegendatyObtained = false;

            while (true)
            {
                string[] materials = Console.ReadLine().ToLower().Split();
                
                for (int i = 0; i < materials.Length; i += 2)
                {
                    
                    if (materials[i + 1] == "shards")
                    {
                        if (keyMaterials.ContainsKey(materials[i + 1]))
                        {
                            keyMaterials[materials[i + 1]] += int.Parse(materials[i]);
                        }
                        else
                        {
                            keyMaterials.Add(materials[i + 1], int.Parse(materials[i]));
                        }

                        if (keyMaterials[materials[i + 1]] >= 250)
                        {
                            legendaryItem = "Shadowmourne";
                            Console.WriteLine($"{legendaryItem} obtained!");
                            keyMaterials[materials[i + 1]] -= 250;
                            isLegendatyObtained = true;
                            break;
                        }
                    }
                    else if (materials[i + 1] == "fragments")
                    {
                        if (keyMaterials.ContainsKey(materials[i + 1]))
                        {
                            keyMaterials[materials[i + 1]] += int.Parse(materials[i]);
                        }
                        else
                        {
                            keyMaterials.Add(materials[i + 1], int.Parse(materials[i]));
                        }

                        if (keyMaterials[materials[i + 1]] >= 250)
                        {
                            legendaryItem = "Valanyr";
                            Console.WriteLine($"{legendaryItem} obtained!");

                            keyMaterials[materials[i + 1]] -= 250;
                            isLegendatyObtained = true;
                            break;
                        }

                    }
                    else if (materials[i + 1] == "motes")
                    {
                        if (keyMaterials.ContainsKey(materials[i + 1]))
                        {
                            keyMaterials[materials[i + 1]] += int.Parse(materials[i]);
                        }
                        else
                        {
                            keyMaterials.Add(materials[i + 1], int.Parse(materials[i]));
                        }

                        if (keyMaterials[materials[i + 1]] >= 250)
                        {
                            legendaryItem = "Dragonwrath";
                            Console.WriteLine($"{legendaryItem} obtained!");
                            keyMaterials[materials[i + 1]] -= 250;
                            isLegendatyObtained = true;
                            break;
                        }
                    }
                    
                    else
                    {
                        if (junk.ContainsKey(materials[i + 1]))
                        {
                            materials[i + 1] += int.Parse(materials[i]);
                        }
                        else
                        {
                            junk.Add(materials[i + 1], int.Parse(materials[i]));
                        }
                    }
                }
                if (isLegendatyObtained == true)
                {
                    break;
                }
            }

            keyMaterials = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, a => a.Value);

            foreach (var keyMaterial in keyMaterials)
            {
                Console.WriteLine($"{keyMaterial.Key}: {keyMaterial.Value}");
            }
            foreach (var junks in junk)
            {
                Console.WriteLine($"{junks.Key}: {junks.Value}");
            }
        }
    }
}
