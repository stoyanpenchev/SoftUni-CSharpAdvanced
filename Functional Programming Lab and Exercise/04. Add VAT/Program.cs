using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, string> funcVat = (a) => (a + (a * 0.2)).ToString("F2");
            //Action<double> twoDigits = funcVat => Console.WriteLine($"{funcVat:f2}");
            Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(x => funcVat(x))
                .ToArray()));
           

            
        }
    }
}
