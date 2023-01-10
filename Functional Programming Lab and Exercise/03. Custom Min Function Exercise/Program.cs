using System;
using System.Linq;

namespace _03._Custom_Min_Function_Excersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> func = (a) => a.Min();


            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int num = nums.First(x => x == func(nums));    
            
            Console.WriteLine(num);


        }
    }
}
