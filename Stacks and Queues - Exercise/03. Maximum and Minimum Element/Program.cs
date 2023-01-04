using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < integer; i++)
            {
                int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (inputs[0] == 1)
                {
                    stack.Push(inputs[1]);
                }
                else if (inputs[0] == 2)
                {
                    stack.Pop();
                }
                else if (inputs[0] == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (inputs[0] == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(String.Join(", ", stack));



        }
    }
}
