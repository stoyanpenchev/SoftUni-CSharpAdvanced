using System;
using System.Linq;

namespace _4._Matrix_Shuffling_Excersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] values = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            while (true)
            {
                string[] comands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = comands[0];
                if (action == "END")
                {
                    break;
                }
                switch (action)
                {
                    case "swap":
                        {
                            if (comands.Length > 5)
                            {
                                Console.WriteLine("Invalid input!");
                                break;
                            }
                            int oldRow = int.Parse(comands[1]);
                            int oldCol = int.Parse(comands[2]);
                            int newRow = int.Parse(comands[3]);
                            int newCol = int.Parse(comands[4]);
                            if (oldRow >= 0 && oldRow < rows && oldCol >= 0 
                                && oldCol < cols && newRow >= 0 && newRow < rows 
                                && newCol >= 0 && newCol < cols)
                            {
                                string oldValue = matrix[oldRow, oldCol];
                                string newValue = matrix[newRow, newCol];
                                for (int row = 0; row < matrix.GetLength(0); row++)
                                {
                                    for (int col = 0; col < matrix.GetLength(1); col++)
                                    {
                                        if (row == oldRow && col == oldCol)
                                        {
                                            matrix[row, col] = newValue;
                                            Console.Write($"{matrix[row, col]} ");
                                            continue;
                                        }
                                        else if (row == newRow && col == newCol)
                                        {
                                            matrix[row, col] = oldValue;
                                            Console.Write($"{matrix[row, col]} ");
                                        }
                                        else
                                        {
                                            Console.Write($"{matrix[row, col]} ");
                                        }
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input!");
                            }

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                }
            }
        }
    }
}
