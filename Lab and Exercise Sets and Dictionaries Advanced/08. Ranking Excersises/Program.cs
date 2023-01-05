using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking_Excersises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var students = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] inputs = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contestName = inputs[0];
                if (contestName == "end of contests")
                {
                    break;
                }
                string password = inputs[1];
                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, password);
                }
            }
            while (true)
            {
                string[] inputs = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contestName = inputs[0];
                if(contestName == "end of submissions")
                {
                    break;
                }
                string password = inputs[1];
                string userName = inputs[2];
                int points = int.Parse(inputs[3]);
                if (contests.ContainsKey(contestName) && contests[contestName] == password)
                {
                    if (!students.ContainsKey(userName))
                    {
                        students.Add(userName, new Dictionary<string, int>());
                    }
                    if (!students[userName].ContainsKey(contestName))
                    {
                        students[userName].Add(contestName, points);
                    }
                    if (students[userName][contestName] < points)
                    {
                        students[userName][contestName] = points;
                    }
                }
            }
            students = students.OrderByDescending(x => x.Value.Sum(y => y.Value)).ToDictionary(x => x.Key, x => x.Value);
            foreach (var student in students)
            {
                Console.WriteLine($"Best candidate is {student.Key} with total {student.Value.Sum(x => x.Value)} points.");
                Console.WriteLine("Ranking:");
                break;
            }
            students = students.OrderBy(x => x.Key).ToDictionary(x => x.Key,x => x.Value);
            foreach (var guy in students)
            {
                Console.WriteLine($"{guy.Key}");
                foreach (var item in guy.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
