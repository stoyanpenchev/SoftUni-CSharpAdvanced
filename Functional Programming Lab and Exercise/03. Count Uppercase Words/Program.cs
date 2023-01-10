using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isPositive = x => char.IsUpper(x[0]);
            string[] text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in text)
            {
                if (isPositive(word))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
