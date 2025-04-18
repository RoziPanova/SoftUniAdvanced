using System;
using System.Linq;

namespace KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j].ToString();
                }
            }
            int counter = 0;
            int removed = 0;
            for (int maxMoves = 8; maxMoves > 0; maxMoves--)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j] == "K")
                        {

                            if (i - 1 >= 0 && j - 2 >= 0)
                            {

                                if (matrix[i - 1, j - 2] == "K")
                                    counter++;
                            }
                            if (i - 1 >= 0 && j + 2 < n)
                            {
                                if (matrix[i - 1, j + 2] == "K")
                                    counter++;
                            }
                            if (i + 1 < n && j - 2 >= 0)
                            {
                                if (matrix[i + 1, j - 2] == "K")
                                    counter++;
                            }
                            if (i + 1 < n && j + 2 < n)
                            {
                                if (matrix[i + 1, j + 2] == "K")
                                    counter++;
                            }
                            if (i - 2 >= 0 && j - 1 >= 0)
                            {
                                if (matrix[i - 2, j - 1] == "K")
                                    counter++;
                            }
                            if (i - 2 >= 0 && j + 1 < n)
                            {
                                if (matrix[i - 2, j + 1] == "K")
                                    counter++;
                            }
                            if (i + 2 < n && j - 1 >= 0)
                            {
                                if (matrix[i + 2, j - 1] == "K")
                                    counter++;
                            }
                            if (i + 2 < n && j + 1 < n)
                            {
                                if (matrix[i + 2, j + 1] == "K")
                                    counter++;
                            }
                        }
                        if (counter==maxMoves)
                        {
                            matrix[i, j] = "0";
                            removed++;
                        }
                        counter = 0;
                    }
                }
            }
            Console.WriteLine(removed);
        }
    }
}
