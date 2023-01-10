using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names_Exsersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<string>, Predicate<int>, List<string>> func = (names, match) =>
            {
                List<string> result = new List<string>();
                foreach (var name in names)
                {
                    if (match(name.Length))
                    {
                        result.Add(name);
                    }
                }
                return result;
            };

            int lenght = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            names = func(names, x => x <= lenght);

            Console.WriteLine(String.Join(Environment.NewLine, names));
        }
    }
}
