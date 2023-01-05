using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator_Excersizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                jagged[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                if (jagged.Length - row > 1)
                {

                    if (jagged[row].Length == jagged[row + 1].Length)
                    {
                        for (int j = 0; j < jagged[row].Length; j++)
                        {
                            jagged[row][j] *= 2;
                            jagged[row + 1][j] *= 2;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < jagged[row].Length; j++)
                        {
                            jagged[row][j] /= 2;
                        }
                        for (int j = 0; j < jagged[row + 1].Length; j++)
                        {
                            jagged[row + 1][j] /= 2;
                        }   
                    }
                }
                
            }
            
            while (true)
            {
                string[] comands = Console.ReadLine().Split();
                string action = comands[0];
                if (action == "End")
                {
                    break;
                }
                switch (action)
                {
                    case "Add":
                        {
                            int atRow = int.Parse(comands[1]);
                            int atCol = int.Parse(comands[2]);
                            int value = int.Parse(comands[3]);
                            if(atRow >= 0 && atRow < jagged.Length && atCol >= 0 && atCol < jagged[atRow].Length)
                            {
                                jagged[atRow][atCol] += value;
                            }
                        }
                        break;
                    case "Subtract":
                        {
                            int atRow = int.Parse(comands[1]);
                            int atCol = int.Parse(comands[2]);
                            int value = int.Parse(comands[3]);
                            if (atRow >= 0 && atRow < jagged.Length && atCol >= 0 && atCol < jagged[atRow].Length)
                            {
                                jagged[atRow][atCol] -= value;
                            }
                        }
                        break;
                }
            }
            foreach (int[] item in jagged)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
