using System;
using System.Linq;

namespace _05._Applied_Arithmetics_Exsersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int[]> add = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i]++;
                }
                return x;
            };
            Func<int[], int[]> multiply = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] *= 2;
                }
                return x;
            };
            Func<int[], int[]> subtract = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i]--;
                }
                return x;
            };
            Action<int[]> print = x => Console.WriteLine(String.Join(" ", x));
            
            while (true)
            {
                string comand = Console.ReadLine();
                if(comand == "end")
                {
                    break;
                }
                switch (comand)
                {
                    case "add":
                        {
                            add(numbers);
                        }
                        break;
                    case "multiply":
                        {
                            multiply(numbers);
                        }
                        break;
                    case "subtract":
                        {
                            subtract(numbers);
                        }
                        break;
                    case "print":
                        {
                            print(numbers);
                        }
                        break;

                }
            }
        }

        
    }
}
