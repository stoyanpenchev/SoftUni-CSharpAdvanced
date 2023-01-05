using System;
using System.Linq;

namespace _5._Snake_Moves_Excersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            string word = Console.ReadLine();
            char[,] matrix = new char[rows, cols];
            int curentWordIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (curentWordIndex == word.Length)
                        {
                            curentWordIndex = 0;
                        }
                        matrix[row, col] = word[curentWordIndex];
                        curentWordIndex++;
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (curentWordIndex == word.Length)
                        {
                            curentWordIndex = 0;
                        }
                        matrix[row, col] = word[curentWordIndex];
                        curentWordIndex++;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }

        }
    }
}
