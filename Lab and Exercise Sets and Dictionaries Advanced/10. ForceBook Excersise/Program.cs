using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._ForceBook_Excersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, SortedSet<string>>();

            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "Lumpawaroo")
                {
                    break;
                }

                if (comand.Contains('|'))
                {
                    string[] comands = comand.Split('|');
                    string forceSide = comands[0].Trim();
                    string forceUser = comands[1].Trim();
                    if (!players.Values.Any(x => x.Contains(forceUser)))
                    {
                        if (!players.ContainsKey(forceSide))
                        {
                            players.Add(forceSide, new SortedSet<string>());
                        }
                        players[forceSide].Add(forceUser);
                    }
                }
                else
                {
                    string[] comands = comand.Split("->");
                    string forceSide = comands[1].Trim();
                    string forceUser = comands[0].Trim();



                    foreach (var player in players)
                    {
                        if (player.Value.Contains(forceUser))
                        {
                            player.Value.Remove(forceUser);
                        }
                    }
                    if (!players.ContainsKey(forceSide))
                    {
                        players.Add(forceSide, new SortedSet<string>());
                    }
                    players[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");

                }

            }
            players = players.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var side in players)
            {
                if (side.Value.Count() > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    foreach (var item in side.Value)
                    {
                        Console.WriteLine($"! {item}");
                    }

                }
            }
        }
    }
}
