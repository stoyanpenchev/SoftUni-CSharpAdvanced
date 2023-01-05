using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            integers = integers.OrderByDescending(x => x).ToList();
            integers = integers.Take(3).ToList();
            Console.WriteLine(String.Join(" ", integers));
        }
    }
}
