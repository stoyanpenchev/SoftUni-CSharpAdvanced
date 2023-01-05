using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols_Excersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var characters = new Dictionary<char, int>();
            foreach (var item in text)
            {
                if (!characters.ContainsKey(item))
                {
                    characters.Add(item, 0);
                }
                characters[item]++;
            }
            characters = characters.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var character in characters)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
