using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            if (queue.Count > 0)
            {
                Console.WriteLine(queue.Max());

            }
            if (queue.Sum() <= foodQuantity)
            {
                Console.WriteLine("Orders complete");
                return;
            }
            else
            {
                while (foodQuantity > queue.Peek())
                {
                    foodQuantity -= queue.Dequeue();
                }
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                return;
            }
            
        }
    }
}
