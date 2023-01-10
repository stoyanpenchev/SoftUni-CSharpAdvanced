using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party__Exersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            
            while (true)
            {
                string[] comand = Console.ReadLine().Split();
                if(comand[0] == "Party!")
                {
                    break;
                }
                string action = comand[0];
                string filter = comand[1];
                string value = comand[2];

                if (action == "Remove")
                {
                    names.RemoveAll(GetPredicate(filter, value));
                }
                else
                {
                    var peopleToDouble = names.FindAll(GetPredicate(filter, value));

                    int index = names.FindIndex(GetPredicate(filter, value));
                    if (index >= 0)
                    {
                        names.InsertRange(index, peopleToDouble);
                    }
                }
            }
            if (names.Any())
            {
                Console.WriteLine($"{String.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "StartsWith":
                    return x => x.StartsWith(value);
                    break;
                case "EndsWith":
                    return y => y.EndsWith(value);
                    break;
                case "Length":
                    return z => z.Length == int.Parse(value);
                    break;
                default:
                    return default(Predicate<string>);
            }
        }
    }
}
