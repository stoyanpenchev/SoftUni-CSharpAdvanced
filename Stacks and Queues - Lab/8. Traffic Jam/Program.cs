using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            int passedCars = 0;
            Queue<string> cars = new Queue<string>();
            while (true)
            {
                string comand = Console.ReadLine();
                if(comand == "end")
                {
                    break;
                }
                if(comand == "green")
                {
                    for (int i = 0; i < num; i++)
                    {
                        if(cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCars++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(comand);
                }
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");

        }
    }
}
