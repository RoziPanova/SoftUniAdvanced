using System;
using System.Linq;

namespace PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            for (int r = 0; r < n; r++)
            {
                int[] input=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = input[c];
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}

