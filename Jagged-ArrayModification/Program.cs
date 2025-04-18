using System;
using System.Data;
using System.Linq;

namespace Jagged_ArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] array = new int[n][];
            for (int i = 0; i < n; i++)
            {
                array[i] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }
            while (true)
            {
                string[]input=Console.ReadLine().Split(" ");
                if (input[0] == "END")
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int c = 0; c < array[i].Length; c++)
                        {
                            Console.Write(array[i][c]+" ");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                string command = input[0];
                int rows = int.Parse(input[1]);
                int cols = int.Parse(input[2]);
                int value = int.Parse(input[3]);
                if (rows < 0 || rows >= array.Length || cols >= array[rows].Length||cols<0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if(command=="Add")
                {
                    array[rows][cols] += value;
                }
                else
                {
                    array[rows][cols] -= value;
                }
            }
        }
    }
}
