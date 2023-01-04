using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightSec = int.Parse(Console.ReadLine());
            int freeWindowSec = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int counter = 0;
            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "END")
                {
                    break;
                }
                if (comand == "green" && cars.Count > 0)
                {

                    int totalTime = greenLightSec;
                    int window = freeWindowSec;
                    while (cars.Count > 0)
                    {
                        string carToCross = cars.Peek();
                        if (totalTime >= carToCross.Length)
                        {
                            totalTime -= carToCross.Length;
                            cars.Dequeue();
                            counter++;
                            
                        }
                        else if(window > totalTime)
                        {
                            totalTime += window;
                            window = 0;
                            if(totalTime - carToCross.Length < 0)
                            {
                                string hiterCar = carToCross.Substring(totalTime, carToCross.Length - totalTime);
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{cars.Peek()} was hit at {hiterCar[0]}.");
                                return;
                            }
                            totalTime -= carToCross.Length;
                            cars.Dequeue();
                            counter++;
                            if(cars.Peek().Length > totalTime)
                            {
                                break;
                            }
                            
                        }
                        else
                        {
                            string hiterCar = carToCross.Substring(totalTime, carToCross.Length - totalTime);
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{cars.Peek()} was hit at {hiterCar[0]}.");
                            return;
                        }
                    }

                }
                else
                {
                    cars.Enqueue(comand);
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
