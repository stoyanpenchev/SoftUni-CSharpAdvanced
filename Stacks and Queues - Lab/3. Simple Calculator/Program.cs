using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ");
            Stack<string> stacks = new Stack<string>(array.Reverse());
            int sum = 0;
            while (stacks.Count > 0)
            {
                if (stacks.Peek() == "-")
                {
                    stacks.Pop();
                    sum -= int.Parse(stacks.Pop());
                }
                else if (stacks.Peek() == "+")
                {
                    stacks.Pop();
                    sum += int.Parse(stacks.Pop());
                }
                else
                {
                    sum += int.Parse(stacks.Pop());
                }



            }
            Console.WriteLine(sum);
        }
    }
}
