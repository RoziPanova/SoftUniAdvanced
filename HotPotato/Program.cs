using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split());
            int turns = int.Parse(Console.ReadLine());
            while (queue.Count > 1)
            {
                for (int i = 0; i < turns-1; i++)
                {
                    if (i != turns)
                    {
                        queue.Enqueue(queue.Dequeue());
                    }
                }

                string removed = queue.Dequeue();
                Console.WriteLine($"Removed {removed}");

            }
            Console.WriteLine($"Last is {queue.SingleOrDefault()}");
        }
    }
}
