using System;
using System.Collections.Generic;

namespace _06._Wardrobe_Excersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var colors = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(",");
                if (!colors.ContainsKey(color))
                {
                    colors.Add(color, new Dictionary<string, int>());
                }
                foreach (var item in clothes)
                {
                    if (!colors[color].ContainsKey(item))
                    {
                        colors[color].Add(item, 0);
                    }
                    colors[color][item]++;
                }
                
            }
            string[] finalInput = Console.ReadLine().Split();
            string theColor = finalInput[0];
            string theCloth = finalInput[1];

            foreach (var item in colors)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloth in item.Value)
                {
                    if (item.Key == theColor && cloth.Key == theCloth)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                }
            }
        }

    }
}
