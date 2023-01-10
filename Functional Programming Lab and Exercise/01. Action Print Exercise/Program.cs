using System;

namespace _01._Action_Print_Exsersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = name => Console.WriteLine(name);
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            print(string.Join(Environment.NewLine, names));
            
        }
    }
}
