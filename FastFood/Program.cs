using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodAvailable = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Console.WriteLine(orders.Max());
            for (int i = 0; i < orders.Count; i++)
            {
                if (foodAvailable >= orders.First())
                {
                    foodAvailable -= orders.Dequeue();
                    i--;
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
                    break;
                }
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}

