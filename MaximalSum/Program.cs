
using System;
using System.Linq;

namespace MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowcols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = rowcols[0];
            int col = rowcols[1];
            int[,] matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int max = int.MinValue;
            int indexRow = 0;
            int indexCol = 0;

            for (int i = 0; i < row - 2; i++)
            {
                for (int j = 0; j < col - 2; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                        matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > max)
                    {
                        max = sum;
                        indexRow = i;
                        indexCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {max}");
            Console.WriteLine($"{matrix[indexRow, indexCol]} {matrix[indexRow, indexCol + 1]} {matrix[indexRow, indexCol + 2]}");
            Console.WriteLine($"{matrix[indexRow + 1, indexCol]} {matrix[indexRow + 1, indexCol + 1]} {matrix[indexRow + 1, indexCol + 2]}");
            Console.WriteLine($"{matrix[indexRow + 2, indexCol]} {matrix[indexRow + 2, indexCol + 1]} {matrix[indexRow + 2, indexCol + 2]}");

        }
    }
}