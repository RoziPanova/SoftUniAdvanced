using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = input[0];
            int S = input[1];
            int X = input[2];
            int[] numbers=Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < N; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < S; i++) 
            {
                stack.Pop();
            }
            if (stack.Count == 0) { Console.WriteLine(0); }
            else if (stack.Contains(X)==true)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine(stack.Min()); }
        }
    }
}

