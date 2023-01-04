using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int buletPrice = int.Parse(Console.ReadLine());
            int gunBarelSize = int.Parse(Console.ReadLine());
            int[] bulets = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int theValue = int.Parse(Console.ReadLine());
            Stack<int> stackBulets = new Stack<int>(bulets);
            Queue<int> queueLocks = new Queue<int>(locks);
            int counter = 0;
            int buletCost = 0;

            int curentGunBarel = gunBarelSize;
            while (true)
            {
                if (stackBulets.Count == 0 || queueLocks.Count == 0)
                {
                    break;
                }
                int curentBulet = stackBulets.Peek();
                int curentLock = queueLocks.Peek();


                if (curentBulet <= curentLock)
                {
                    counter++;
                    Console.WriteLine("Bang!");
                    buletCost += buletPrice;
                    stackBulets.Pop();
                    queueLocks.Dequeue();
                    if (counter == gunBarelSize)
                    {
                        counter = 0;
                        if (stackBulets.Count > 0)
                        {
                            Console.WriteLine("Reloading!");
                        }

                    }
                }
                else
                {
                    counter++;
                    Console.WriteLine("Ping!");
                    buletCost += buletPrice;
                    stackBulets.Pop();
                    if (counter == curentGunBarel)
                    {
                        counter = 0;
                        if (stackBulets.Count > 0)
                        {
                            Console.WriteLine("Reloading!");
                        }

                    }
                }
            }
            if (stackBulets.Count >= 0 && queueLocks.Count == 0)
            {
                Console.WriteLine($"{stackBulets.Count} bullets left. Earned ${theValue - buletCost}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
                return;
            }
        }
    }
}
