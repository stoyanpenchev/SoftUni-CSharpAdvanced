using System;
using System.Linq;

namespace _1._Diagonal_Difference_Exceresize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int rows = size;
            int cols = size;
            int[,] matrix = new int[rows, cols];
            int primeSum = 0;
            int secondSum = 0;
            int totalSum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primeSum += matrix[i, i];
                secondSum += matrix[i, size - 1 - i];
            }
            totalSum = primeSum - secondSum;
            Console.WriteLine($"{Math.Abs(totalSum)}");
        }
    }
}
