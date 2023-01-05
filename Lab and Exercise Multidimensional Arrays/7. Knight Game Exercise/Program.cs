using System;

namespace _7._Knight_Game_Excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            if(size < 3)
            {
                Console.WriteLine(0);
                return;
            }
            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                string values = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = values[col];
                }
            }
            int knightsRemoved = 0;
            while (true)
            {
                int countAttacker = 0;
                int rowAttacker = 0;
                int colAttacker = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if(matrix[row, col] == 'K')
                        {
                            int atackedKnights = CountAttackedKnights(row, col, size, matrix);
                            if(countAttacker < atackedKnights)
                            {
                                countAttacker = atackedKnights;
                                rowAttacker = row;
                                colAttacker = col;
                            }
                        }
                    }
                }
                if(countAttacker == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowAttacker, colAttacker] = '0';
                    knightsRemoved++;
                }
            }
            Console.WriteLine(knightsRemoved);
        }

        static int CountAttackedKnights(int row, int col, int size, char[,] matrix)
        {
            int attackedKnights = 0;
            // horizontal left-UP
            if(ISCellValid(row - 1, col - 2, size))
            {
                if(matrix[row - 1, col - 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            // horizontal left - down
            if (ISCellValid(row + 1, col - 2, size))
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            //horizontal right - up
            if (ISCellValid(row - 1, col + 2, size))
            {
                if (matrix[row - 1, col + 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            //horizontal right - down
            if (ISCellValid(row + 1, col + 2, size))
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            //vertical down - left
            if (ISCellValid(row + 2, col - 1, size))
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            //vertical down - right
            if (ISCellValid(row + 2, col + 1, size))
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            //vertical up - left
            if (ISCellValid(row - 2, col - 1, size))
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            // vertical up - right
            if (ISCellValid(row - 2, col + 1, size))
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            return attackedKnights;
        }
        static bool ISCellValid(int row, int col, int size)
        {
            return (row >= 0 && row < size && col >= 0 && col < size);
        }
    }
}
