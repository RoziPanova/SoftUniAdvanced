using System;
using System.Linq;

namespace SumMatrixElements
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
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            int sum = 0;
            foreach (int item in matrix)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}

