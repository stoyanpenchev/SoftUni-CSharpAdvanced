using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
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

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] cmd = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = cmd[col];                
                }
                
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
