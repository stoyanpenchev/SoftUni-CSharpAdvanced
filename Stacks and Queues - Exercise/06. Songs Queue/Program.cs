using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);
            while (queue.Count > 0)
            {
                string[] comands = Console.ReadLine().Split();
                string action = comands[0];
                switch (action)
                {
                    case "Play":
                        {
                            queue.Dequeue();
                        }
                        break;
                    case "Add":
                        {
                            string songName = string.Join(" ", comands.Skip(1));
                            if (!queue.Contains(songName))
                            {
                                queue.Enqueue(songName);
                            }
                            else
                            {
                                Console.WriteLine($"{songName} is already contained!");
                            }
                        }
                        break;
                    case "Show":
                        {
                            Console.WriteLine(string.Join(", ", queue));
                        }
                        break;
                }
            }
            Console.WriteLine("No more songs!");

        }
    }
}
