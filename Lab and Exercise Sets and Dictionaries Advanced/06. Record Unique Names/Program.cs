using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var unique = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                unique.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join(Environment.NewLine, unique));
        }
    }
}
