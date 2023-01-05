﻿using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int rows = size;
            int cols = size;
            int[,] matrix = new int[rows, cols];
            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = values[col];
                }
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                    col++;
                }
                Console.WriteLine(sum);
                
            }
        }
    }
}
