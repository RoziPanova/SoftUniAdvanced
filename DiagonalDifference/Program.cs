using System;
using System.Linq;

namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,]matrix=new int[n,n];
            for (int i = 0; i < n; i++)
            {
                int[]input=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int k = 0; k < n; k++)
                {
                    matrix[i, k] = input[k];
                }
            }
            int sumPrimary=0, sumSecondary=0;
            for(int i=0; i<n; i++)
            {
                sumPrimary += matrix[i, i];
                sumSecondary += matrix[i,n-1-i];
            }
            Console.WriteLine(Math.Abs(sumPrimary-sumSecondary));
        }
    }
}
