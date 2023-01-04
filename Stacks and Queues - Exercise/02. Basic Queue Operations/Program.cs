using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int toEnqueue = inputs[0];
            int toDequeue = inputs[1];
            int toSearch = inputs[2];
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(nums);
            for (int i = 0; i < toDequeue; i++)
            {
                queue.Dequeue();
            }
            if(queue.Count == 0)
            {
                Console.WriteLine(queue.Count);
                return;
            }
            else if (queue.Contains(toSearch))
            {
                Console.WriteLine("true");
                return;
            }
            else
            {
                Console.WriteLine($"{queue.Min()}");
                return;
            }

        }
    }
}
