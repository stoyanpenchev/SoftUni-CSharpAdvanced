using System;
using System.Linq;

namespace _2._Squares_in_Matrix_Excersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            string[,] matrix = new string[rows, cols];
            int counter = 0;

            for (int row = 0; row < rows; row++)
            {
                string[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = values[col];
                    
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    string str1 = string.Empty;
                    string str2 = string.Empty;
                    string str3 = string.Empty;
                    string str4 = string.Empty;
                    if(col < matrix.GetLength(1) - 1 && row < matrix.GetLength(0) - 1)
                    {
                    str1 = matrix[row, col];
                    str2 = matrix[row, col + 1];
                    str3 = matrix[row + 1, col];
                    str4 = matrix[row + 1, col + 1];

                    }
                    else
                    {
                        break;
                    }
                    if(str1 == str2 && str2 == str3 && str3 == str4)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
