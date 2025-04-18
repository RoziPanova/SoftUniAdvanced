using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(", "));
            while (queue.Count > 0)
            {
                string commands=Console.ReadLine();
                if (commands.Contains("Add"))
                {
                    commands=commands.Remove(0,4);
                    if (queue.Contains(commands)==false)
                    {
                        queue.Enqueue(commands);
                    }
                    else
                    {
                        Console.WriteLine($"{commands} is already contained!");
                    }
                }
                else if (commands.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (commands.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
