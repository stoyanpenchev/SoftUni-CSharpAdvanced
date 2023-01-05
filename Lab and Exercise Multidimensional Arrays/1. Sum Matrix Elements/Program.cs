using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            //int rows = sizes[0];
            //int cols = sizes[1];
            //int[,] matrix = new int[rows, cols];
            //int sum = 0;
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        matrix[row, col] = colElements[col];
            //        sum += matrix[row, col];
            //    }
            //}

            //Console.WriteLine(matrix.GetLength(0));
            //Console.WriteLine(matrix.GetLength(1));
            //Console.WriteLine(sum);

            int counter = 1;
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    //Console.Write($"matrix[{row},{col}]= {counter}");
                    matrix[row, col] = counter;
                    counter++;
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");

                }
                Console.WriteLine();
            }
        }
    }
}
