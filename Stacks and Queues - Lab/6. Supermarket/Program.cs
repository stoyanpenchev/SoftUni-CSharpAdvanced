using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "End")
                {
                    Console.WriteLine($"{names.Count} people remaining.");
                    return;
                }
                else if(input == "Paid")
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
                else
                {
                    names.Enqueue(input);
                }

            }


        }
    }
}
