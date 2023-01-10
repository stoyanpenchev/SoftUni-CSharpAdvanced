using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module_Exsersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var filters = new Dictionary<string, Predicate<string>>();

            while (true)
            {
                string[] comands = Console.ReadLine().Split(";");
                if (comands[0] == "Print")
                {
                    break;
                }
                string action = comands[0];
                string filter = comands[1];
                string parameter = comands[2];
                if (action == "Remove filter")
                {
                    filters.Remove(filter + parameter);
                }
                else
                {
                    filters.Add(filter + parameter, GetPredicate(filter, parameter));                  
                }

            }
            foreach (var filter in filters)
            {
                names.RemoveAll(filter.Value);
            }
            if(names.Count >= 0)
            {
                Console.Write(String.Join(" ", names));
            }
        }

        private static Predicate<string> GetPredicate(string filter, string parameter)
        {
            switch (filter)
            {
                case "Starts with":
                    return x => x.StartsWith(parameter);
                    break;
                case "Ends with":
                    return x => x.EndsWith(parameter);
                    break;
                case "Length":
                    return x => x.Length == int.Parse(parameter);
                    break;
                case "Contains":
                    return x => x.Contains(parameter);
                    break;
                default:
                    return null;

            }
        }
    }
}
