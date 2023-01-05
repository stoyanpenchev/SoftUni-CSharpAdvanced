using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                if(inputs.Length > 1)
                {
                    for (int j = 0; j < inputs.Length; j++)
                    {
                        set.Add(inputs[j]);
                    }
                }
                else
                {
                    set.Add(inputs[0]);
                }
            }
            set = set.OrderBy(x => x).ToHashSet();
            Console.WriteLine(String.Join(" ", set));
        }
    }
}
