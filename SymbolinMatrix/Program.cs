using System;
using System.Linq;

namespace SymbolinMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int r = 0; r < n; r++)
            {
                char[] input = Console.ReadLine().ToArray();
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = input[c];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool flag=false;
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (matrix[r,c]==symbol)
                    {
                        flag= true;
                        Console.WriteLine($"({r}, {c})");
                        break;
                    }
                }
                if (flag==true)
                {
                    break;
                }
            }
            if (flag==false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
