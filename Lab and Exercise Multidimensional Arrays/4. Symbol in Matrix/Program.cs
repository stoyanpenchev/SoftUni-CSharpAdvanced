using System;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizes = int.Parse(Console.ReadLine());
            int rows = sizes;
            int cols = sizes;
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string values = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = values[col];
                }
            }
            string symbol = Console.ReadLine();
            string currentSymbol = symbol;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if(matrix[row, col].ToString() == currentSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");

        }
    }
}
