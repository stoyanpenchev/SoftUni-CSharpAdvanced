using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude_Exsersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> reverse = numbers =>
            {
                List<int> result = new List<int>();
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    result.Add(numbers[i]);
                }
                return result;
            };

            Func<List<int>, Predicate<int>, List<int>> excludeDevisible = (numbers, match) =>
            {
                List<int> result = new List<int>();
                foreach (int number in numbers)
                {
                    if (!match(number))
                    {
                        result.Add(number);
                    }
                }
                return result;
            };


            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int numberToDivise = int.Parse(Console.ReadLine());

            numbers = excludeDevisible(numbers, x => x % numberToDivise == 0);
            numbers = reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
