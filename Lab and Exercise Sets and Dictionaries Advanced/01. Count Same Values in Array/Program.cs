using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_Sets_and_Dictionaries_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            var numbers = new Dictionary<double, int>();
            foreach (var number in nums)
            {
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }
                numbers[number]++;
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
