using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            Func<Person, string, int, bool> ageFilter = (p, c, a) => c == "older" ? p.Age >= a : p.Age < a;
            Func<Person, string[], string> formater = (p, f) =>
            {
                string fString = string.Empty;
                if (f.Length == 2)
                {
                    if (f[0] == "name")
                    {
                        fString = "{0} - {1}";
                    }
                    else
                    {
                        fString = "{1} - {0}";
                    }
                }
                else
                {
                    if (f[0] == "name")
                    {
                        fString = "{0}";
                    }
                    else
                    {
                        fString = "{1}";
                    }
                }
                return string.Format(fString, p.Name, p.Age);
            };

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people[i] = new Person
                {
                    Name = inputs[0],
                    Age = int.Parse(inputs[1]),

                };
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(Environment.NewLine, 
                people
                .Where(x => ageFilter(x, condition, age))
                .Select(p => formater(p, format)).ToArray()));
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
