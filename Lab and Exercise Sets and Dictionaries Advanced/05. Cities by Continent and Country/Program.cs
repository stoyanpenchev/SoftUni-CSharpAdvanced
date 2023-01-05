using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] comands = Console.ReadLine().Split(" ");
                string continent = comands[0];
                string country = comands[1];
                string city = comands[2];
                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                    if (!continents[continent].ContainsKey(country))
                    {
                        continents[continent][country] = new List<string>();
                        continents[continent][country].Add(city);
                    }
                }
                else
                {
                    if (!continents[continent].ContainsKey(country))
                    {
                        continents[continent].Add(country, new List<string>());
                    }
                    continents[continent][country].Add(city);
                }

            }
            foreach (var continentos in continents)
            {
                Console.WriteLine($"{continentos.Key}:");
                foreach (var item in continentos.Value)
                {
                    Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
