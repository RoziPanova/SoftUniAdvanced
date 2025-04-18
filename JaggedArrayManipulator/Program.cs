using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] matrix = new double[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    for (int k = i; k <= i + 1; k++)
                    {
                        for (int m = 0; m < matrix[k].Length; m++)
                        {
                            matrix[k][m] *= 2;
                        }
                    }
                }
                else
                {
                    for (int k = i; k <= i + 1; k++)
                    {
                        for (int m = 0; m < matrix[k].Length; m++)
                        {
                            matrix[k][m] /= 2;
                        }
                    }
                }
            }


            string commands;
            while ((commands = Console.ReadLine()) != "End")
            {
                var tokens = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens[0] == "Add" || tokens[0] == "Subtract" && tokens.Length == 4)
                {
                    string command = tokens[0];
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                    double value = double.Parse(tokens[3]);
                    if (row < n && row >= 0 && col >= 0 && col < matrix[row].Length)
                    { 
                        if (command == "Add")
                        {
                            matrix[row][col] += value;
                        }
                        else
                        {
                            matrix[row][col] -= value;
                        }

                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
/*
5
10 20 30
1 2 3
2
2
10 10
Add 0 10 10
Add 0 0 10
Subtract -3 0 10
Subtract 3 0 10
End
 */
