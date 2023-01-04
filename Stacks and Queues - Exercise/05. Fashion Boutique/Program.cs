using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes);
            int currCloth = 0;
            int clothSum = 0;
            int rackCounter = 0;
            for (int i = 0; i < clothes.Length; i++)
            {
                currCloth = stack.Pop();

                if (clothSum + currCloth < capacity)
                {
                    clothSum += currCloth;
                }
                else if (clothSum + currCloth == capacity)
                {
                    if (stack.Count > 0)
                    {
                        rackCounter++;
                        clothSum = 0;
                    }
                    else
                    {
                        break;
                    }

                }
                else if(clothSum + currCloth > capacity)
                {
                    rackCounter++;
                    clothSum = currCloth;
                }


            }
            if(clothSum > 0)
            {
                rackCounter++;
            }
            Console.WriteLine(rackCounter);

        }
    }
}
