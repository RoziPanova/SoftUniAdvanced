using System;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] array = new long[n][];
            array[0] = new long[1] { 1 };
            for (int i = 1; i < n; i++)
            {
                array[i] = new long[i + 1];
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (j < array[i-1].Length)
                    {
                        array[i][j] += array[i - 1][j];
                    }
                    if (j>0)
                    {
                        array[i][j] += array[i - 1][j-1];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < array[i].Length; k++)
                {
                    Console.Write(array[i][k]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
