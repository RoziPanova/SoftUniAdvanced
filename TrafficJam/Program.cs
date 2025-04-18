using System;
using System.Collections.Generic;

namespace TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input;
            Queue<string> queue = new Queue<string>();
            int counter = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input != "green")
                {
                    queue.Enqueue(input);
                }
                else if (input == "green" && queue.Count >= n)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                    }
                }
                else if (input == "green" && queue.Count < n)
                {
                    for (int i = 0; i <queue.Count; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        i--;
                        counter++;
                    }
                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}

