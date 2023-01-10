using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates_Exsersise
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int endRange = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] numbers = Enumerable.Range(1, endRange).ToArray();
            
            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (var dividor in dividers)
            {
                predicates.Add(x => x % dividor == 0);
            }

            foreach (var number in numbers)
            {
                bool isNividible = true;
                foreach (var match in predicates)
                {
                    if (!match(number))
                    {
                        isNividible = false;
                        break;
                    }
                }
                if (isNividible)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
