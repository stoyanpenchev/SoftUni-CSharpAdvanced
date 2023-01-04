using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> stack = new Stack<string>();
            stack.Push(string.Empty);
            for (int i = 0; i < num; i++)
            {
                string[] comands = Console.ReadLine().Split();
                string action = comands[0];
                switch (action)
                {
                    case "1":
                        {
                            string someString = comands[1];
                            text.Append(someString);
                            stack.Push(text.ToString());

                        }
                        break;
                    case "2":
                        {
                            int count = int.Parse(comands[1]);
                            //string substring = text.ToString().Substring(text.Length - count, count);
                            text = text.Remove(text.Length - count, count);
                            stack.Push(text.ToString());

                        }
                        break;
                    case "3":
                        {
                            int index = int.Parse(comands[1]);
                            if (index >= 0 && index <= text.Length)
                            {
                                Console.WriteLine(text[index - 1]);

                            }
                        }
                        break;
                    case "4":
                        {
                            stack.Pop();
                            text = new StringBuilder(stack.Peek());
                            
                        }
                        break;
                }
            }
        }
    }
}
