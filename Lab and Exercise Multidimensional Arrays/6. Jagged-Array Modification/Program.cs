using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            }
            while (true)
            {
                string[] comands = Console.ReadLine().Split();
                string action = comands[0];
                if(action == "END")
                {
                    break;
                }
                switch (action)
                {
                    case "Add":
                        {
                            int row = int.Parse(comands[1]);
                            int col = int.Parse(comands[2]);
                            int newValue = int.Parse(comands[3]);
                            if(row >= 0 && row < jaggedArray.Length && col >=0 && col < jaggedArray[row].Length)
                            {
                                jaggedArray[row][col] += newValue;
                            }
                            else
                            {
                                Console.WriteLine("Invalid coordinates");
                                
                            }

                        }
                        break;
                    case "Subtract":
                        {
                            int row = int.Parse(comands[1]);
                            int col = int.Parse(comands[2]);
                            int newValue = int.Parse(comands[3]);
                            if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                            {
                                jaggedArray[row][col] -= newValue;
                            }
                            else
                            {
                                Console.WriteLine("Invalid coordinates");
                                
                            }

                        }
                        break;
                }
            }
            foreach (int[] jaged in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", jaged));
            }
        }
    }
}
