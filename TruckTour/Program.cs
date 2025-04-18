using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Queue<string> q = new Queue<string>();
            for (long i = 0; i < n; i++)
            {
                q.Enqueue(Console.ReadLine());
            }
            bool flag = false;
            for (long i = 0; i < n; i++)
            {
                long fuel = 0;
                foreach (var item in q)
                {
                    fuel += item.Trim().Split(" ").Select(long.Parse).ToArray()[0];
                    fuel -= item.Trim().Split(" ").Select(long.Parse).ToArray()[1];

                    if (fuel < 0)
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    Console.WriteLine(i);
                    return;
                }
                q.Enqueue(q.Dequeue());
            }

        }
    }
}
