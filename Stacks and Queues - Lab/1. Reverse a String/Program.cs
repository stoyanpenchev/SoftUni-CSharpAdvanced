using System;
using System.Collections;
using System.Collections.Generic;

namespace Stacks_and_Queues___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string input = Console.ReadLine();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i].ToString());
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
