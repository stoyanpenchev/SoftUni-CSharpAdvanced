using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] kids = Console.ReadLine().Split();
            int hotNum = int.Parse(Console.ReadLine());
            int counter = 0;
            Queue<string> names = new Queue<string>();
            for (int i = 0; i < kids.Length; i++)
            {
                names.Enqueue(kids[i]);
            }


            while (names.Count > 1)
            {
                string currentKid = names.Dequeue();
                counter++;
                if (counter != hotNum)
                {
                    
                    names.Enqueue(currentKid);
                }
                else if (counter == hotNum)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    counter = 0;
                }

            }
            Console.WriteLine($"Last is {names.Peek()}");
        }
    }
}
