using System;
using System.Linq;

namespace Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(n => n).ToArray();
            if (array.Length < 3)
            {
                Console.WriteLine(string.Join(" ", array));
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
