using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements_Excersises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int first = sets[0];
            int second = sets[1];
            var firstHashSet = new HashSet<int>();
            var secondHashSet = new HashSet<int>();
            var thirdHashSet = new HashSet<int>();
            for (int i = 0; i < first; i++)
            {
                firstHashSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int j = 0; j < second; j++)
            {
                secondHashSet.Add(int.Parse(Console.ReadLine()));
            }
            firstHashSet.IntersectWith(secondHashSet);
            Console.WriteLine(String.Join(" ", firstHashSet));
        }
    }
}
