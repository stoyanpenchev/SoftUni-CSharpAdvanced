using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vlogers = new List<Vlogers>();

            while (true)
            {
                string[] comands = Console.ReadLine().Split();
                if (comands[0] == "Statistics")
                {
                    break;
                }
                if (comands[1] == "joined")
                {
                    string name = comands[0];
                    if (!vlogers.Any(x => x.Name == name))
                    {
                        vlogers.Add(new Vlogers(name));
                    }
                }
                if (comands[1] == "followed")
                {
                    string follower = comands[0];
                    string followed = comands[2];
                    if (follower != followed
                        && vlogers.Any(x => x.Name == follower)
                        && vlogers.Any(x => x.Name == followed))
                    {

                        Vlogers vloger = vlogers.Single(x => x.Name == follower);
                        vloger.Following.Add(followed);
                        Vlogers followedVloger = vlogers.Single(x => x.Name == followed);
                        followedVloger.Followers.Add(follower);

                    }
                    else
                    {
                        continue;
                    }

                }
            }
            int counter = 0;
            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");
            vlogers = vlogers.OrderByDescending(x => x.Followers.Count).ThenBy(p => p.Following.Count).ToList();
            foreach (var vloger in vlogers)
            {
                counter++;
                Console.WriteLine($"{counter}. {vloger.Name} : {vloger.Followers.Count} followers, {vloger.Following.Count} following");
                if(counter == 1)
                {
                    foreach (var item in vloger.Followers)
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }

            }
            
        }
        class Vlogers
        {
            public Vlogers(string name)
            {
                Name = name;
                Followers = new SortedSet<string>();
                Following = new HashSet<string>();
            }
            public string Name { get; set; }
            public SortedSet<string> Followers { get; set; }
            public HashSet<string> Following { get; set; }
        }
    }
}
