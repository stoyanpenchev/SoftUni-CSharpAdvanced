using System;
using System.Linq;

namespace _11._TriFunction_Exsersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> func = (name, num) =>
            {
                return name.Sum(x => x) >= num;
                //int sum = 0;
                //for (int i = 0; i < name.Length; i++)
                //{
                //    sum += name[i];
                //}
                //if (sum >= num)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
            };

            Func<string[], int, Func<string, int, bool>, string> getName = (names, num, match) =>
           {
               return names.FirstOrDefault(name => match(name, num));
           };

            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(getName(names, number, func));
            //PrintName(names, number, func);
        }

        //private static void PrintName(string[] names, int number, Func<string, int, bool> func)
        //{
        //    foreach (var name in names)
        //    {
        //        if(func(name, number))
        //        {
        //            Console.WriteLine(name);
        //            return;
        //        }


        //    }
        //}
    }
}
