using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowscols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowscols[0];
            int cols = rowscols[1];
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int k = 0; k < cols; k++)
                {
                    matrix[i, k] = input[k];
                }
            }
            int maxSum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;
            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < cols - 1; c++)
                {
                    int sum = matrix[r, c] + matrix[r, c + 1] +
                              matrix[r + 1, c] + matrix[r + 1, c + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = r;
                        colIndex = c;
                    }
                }
            }
            Console.WriteLine($"{matrix[rowIndex, colIndex]} {matrix[rowIndex, colIndex + 1]}");
            Console.WriteLine($"{matrix[rowIndex + 1, colIndex]} {matrix[rowIndex + 1, colIndex + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}

