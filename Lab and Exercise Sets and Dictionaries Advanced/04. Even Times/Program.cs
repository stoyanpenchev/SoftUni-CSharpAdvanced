using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var collection = new Dictionary<int, int>();
            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (!collection.ContainsKey(input))
                {
                    collection[input] = 0;
                }
                collection[input]++;
                
            }
            Console.WriteLine(collection.Single(x => x.Value % 2 == 0).Key);
        }
    }
}
