using System;
using System.Linq;
using System.Text;

namespace _04._Find_Evens_or_Odds_Exsersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<int> isOdd = x => x % 2 != 0;
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string action = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            if(action == "odd")
            {
                for (int i = input[0]; i <= input[1]; i++)
                {
                    if (isOdd(i))
                    {
                        sb.Append(i+ " ");
                    }
                }
            }
            else
            {
                for (int i = input[0]; i <= input[1]; i++)
                {
                    if (isEven(i))
                    {
                        sb.Append(i + " ");
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
