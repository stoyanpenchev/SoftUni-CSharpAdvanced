using System;
using System.Linq;

namespace _3._Maximal_Sum_Excersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int[,] matrix = new int[rows, cols];
            int sum = 0;
            int totalSum = int.MinValue;

            for (int row = 0; row < rows; row++)
            {
                int[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = values[col];

                }
            }
            int maxSumRow = 0;
            int maxSumCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    
                    sum += matrix[row, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row, col + 2];
                    sum += matrix[row + 1, col];
                    sum += matrix[row + 1, col + 1];
                    sum += matrix[row + 1, col + 2];
                    sum += matrix[row + 2, col];
                    sum += matrix[row + 2, col + 1];
                    sum += matrix[row + 2, col + 2];
                    if(sum > totalSum)
                    {
                        maxSumRow = row;
                        maxSumCol = col;
                        
                        totalSum = sum;
                    }
                    sum = 0;
                }
            }          
            Console.WriteLine($"Sum = {totalSum}");
            for (int row = maxSumRow; row < maxSumRow + 3; row++)
            {               
                for (int col = maxSumCol; col < maxSumCol + 3; col++)
                {
                    Console.Write($"{matrix[row, col]} ");

                }
                Console.WriteLine();
            }
        }
    }
}
