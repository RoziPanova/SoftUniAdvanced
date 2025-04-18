using System;
using System.Linq;

namespace SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = input[0];
            int col = input[1];
            char[,] matrix = new char[row, col];
            for (int i = 0; i < row; i++)
            {
                char[] symbol = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = symbol[j];
                }
            }
            int counter = 0;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1]
                        && matrix[i, j] == matrix[i + 1, j + 1]
                        && matrix[i, j] == matrix[i + 1, j])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
