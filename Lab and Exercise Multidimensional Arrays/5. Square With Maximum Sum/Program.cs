using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] comands = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = comands[0];
            int cols = comands[1];
            int[,] matrix = new int[rows, cols];
            int sum = 0;
            int subMatrixRows = 2;
            int subMatrixCols = 2;

            for (int row = 0; row < rows; row++)
            {
                int[] cmd = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = cmd[col];
                }
            }
            int maxSum = 0;
            int squareStartRow = 0;
            int sqareStartCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum += matrix[row, col];
                    sum += matrix[row + 1, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row + 1, col + 1];
                    if(sum > maxSum)
                    {
                        squareStartRow = row;
                        sqareStartCol = col;
                        maxSum = sum;
                    }
                    sum = 0;
                }
            }
            Console.WriteLine($"{matrix[squareStartRow, sqareStartCol]} {matrix[squareStartRow, sqareStartCol + 1]}");
            Console.WriteLine($"{matrix[squareStartRow + 1, sqareStartCol]} {matrix[squareStartRow + 1, sqareStartCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
