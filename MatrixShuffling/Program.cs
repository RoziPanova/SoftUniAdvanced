using System;
using System.Linq;

namespace MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowcol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = rowcol[0];
            int col = rowcol[1];
            string[,] matrix = new string[row, col];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            string commands;
            while ((commands = Console.ReadLine()) != "END")
            {
                var input = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input[0] == "swap" && input.Length == 5)
                {
                    int row1 = int.Parse(input[1]);
                    int col1 = int.Parse(input[2]);
                    int row2 = int.Parse(input[3]);
                    int col2 = int.Parse(input[4]);

                    if (input[0] != "swap" || row < row1 || row < row2 || row1 < 0 || row2 < 0
                        || col < col1 || col < col2 || col1 < 0 || col2 < 0)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    string swap1 = matrix[row1, col1];
                    string swap2 = matrix[row2, col2];
                    matrix[row1, col1] = swap2;
                    matrix[row2, col2] = swap1;
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
/*
1 2
Hello World
0 0 0 1
swap 0 0 0 1
swap 0 1 0 0
END
 */
