using System;
using System.Linq;

namespace SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowcol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = rowcol[0];
            int col = rowcol[1];
            string[,] matrix = new string[row, col];
            string snake = Console.ReadLine();
            int index = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (index == snake.Length)
                    {
                        index = 0;
                    }
                    matrix[i, j] = snake[index].ToString();
                    index++;
                }
            }
            for (int i = 0; i < row; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(matrix[i, j].ToString());
                    }
                }
                else
                {
                    for (int j = col - 1; j >= 0; j--)
                    {
                        Console.Write(matrix[i, j].ToString());
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
