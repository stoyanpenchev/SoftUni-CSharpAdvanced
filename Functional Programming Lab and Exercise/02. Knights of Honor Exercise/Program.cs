using System;

namespace _02._Knights_of_Honor_Exsersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[], string> printWithAdded = (names, tittle) =>
            {
                foreach (var name in names)
                {
                    Console.WriteLine($"{tittle} {name}");
                }
            };
            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            printWithAdded(strings, "Sir");
        }
    }
}
