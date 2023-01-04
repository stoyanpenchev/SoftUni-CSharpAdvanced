using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations_Exceresize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int integersToPush = nums[0];
            int integersToPop = nums[1];
            int theInteger = nums[2];
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int smallestNum = int.MaxValue;
            Stack<int> stack = new Stack<int>(integers);


            for (int i = 0; i < integersToPop; i++)
            {
                stack.Pop();
                if (stack.Count == 0)
                {
                    Console.WriteLine(stack.Count);
                    return;
                }
            }
            while (true)
            {
                if (stack.Peek() == theInteger)
                {

                    Console.WriteLine("true");
                    return;
                }

                else
                {
                    if (stack.Peek() < smallestNum)
                    {
                        smallestNum = stack.Pop();
                    }
                    else
                    {
                        stack.Pop();
                    }
                    if (stack.Count == 0)
                    {
                        Console.WriteLine($"{smallestNum}");
                        return;
                    }
                }

            }


        }
    }
}
