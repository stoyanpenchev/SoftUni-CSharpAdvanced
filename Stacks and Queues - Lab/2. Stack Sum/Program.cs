using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> stacks = new Stack<int>(nums);
            int count = 0;
            while (true)
            {
                string[] comands = Console.ReadLine().Split();
                string action = comands[0].ToLower();
                if(action == "end")
                {
                    break;
                }
                if(action == "add")
                {
                    int firstNum = int.Parse(comands[1]);
                    int secondNum = int.Parse(comands[2]);
                    stacks.Push(firstNum);
                    stacks.Push(secondNum);

                }
                else if(action == "remove")
                {
                    count = int.Parse(comands[1]);
                    if(count > stacks.Count)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stacks.Pop();
                        }
                    }

                }
            }
            Console.WriteLine($"Sum: {stacks.Sum()}");

        }
    }
}
