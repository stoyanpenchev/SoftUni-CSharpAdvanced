using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characters = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            
            if (characters.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }
            for (int i = 0; i < characters.Length; i++)
            {
                if(characters[i] == '(' || characters[i] == '{' || characters[i] == '[')
                {
                    stack.Push(characters[i]);
                }
                else
                {
                    if(stack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    if((stack.Peek() == '(' && characters[i] == ')') || (stack.Peek() == '{' && characters[i] == '}') || (stack.Peek() == '[' && characters[i] == ']'))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            if(stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
                    
        }
    }
}
