using System;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] paschal = new long[n][];
            for (int row = 0; row < n; row++)
            {
                paschal[row] = new long[row + 1];
                for (int col = 0; col < paschal[row].Length; col++)
                {
                    if (row == 0)
                    {
                        paschal[row][col] = 1;
                        continue;
                    }
                    long currentValue = 0;
                    if(col > 0)
                    {
                        currentValue += paschal[row - 1][col - 1];
                    }
                    if(paschal[row].Length - 1 > col)
                    {
                        currentValue += paschal[row - 1][col];
                    }
                    paschal[row][col] = currentValue;
                }
            }

            for (int row = 0; row < paschal.Length; row++)
            {
                for (int col = 0; col < paschal[row].Length; col++)
                {
                    Console.Write($"{paschal[row][col]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
