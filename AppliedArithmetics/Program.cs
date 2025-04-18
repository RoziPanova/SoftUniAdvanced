using System;
using System.Linq;

namespace AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input;
            Func<int[], int[]> add = (int[] n) =>
            {
                for (int i = 0; i < n.Length; i++)
                {
                    n[i] += 1;
                }
                return n;
            };
            Func<int[], int[]> multiply = (int[] n) =>
            {
                for (int i = 0; i < n.Length; i++)
                {
                    n[i] *= 2;
                }
                return n;
            };
            Func<int[], int[]> subtract = (int[] n) =>
            {
                for (int i = 0; i < n.Length; i++)
                {
                    n[i] -= 1;
                }
                return n;
            };
            Action<int[]> print = (int[] n) => { Console.WriteLine(string.Join(" ", n)); };
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "add")
                {
                    add(nums);
                }
                else if (input == "multiply")
                {
                    multiply(nums);
                }
                else if (input == "subtract")
                {
                    subtract(nums);
                }
                else if (input=="print")
                {
                    print(nums);
                }
            }
        }
    }
}
