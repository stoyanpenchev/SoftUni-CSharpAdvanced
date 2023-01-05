using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<decimal>>(); 
            for (int i = 0; i < n; i++)
            {
                string[] comands = Console.ReadLine().Split(" ");
                string student = comands[0];
                decimal grade = decimal.Parse(comands[1]);
                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<decimal>());
                }
                students[student].Add(grade);
            }
            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var item in student.Value)
                {
                    Console.Write($"{item:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
