using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = input[0];
            int S = input[1];
            int X = input[2];
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0) { Console.WriteLine(0); }
            else if (queue.Contains(X) == true)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine(queue.Min()); }
        }
    }
}



