using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]array=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            HashSet<int> finalSet = new HashSet<int>();
            for (int i = 0; i < array[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < array[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }
            finalSet=set1.Intersect(set2).ToHashSet();
            Console.WriteLine(string.Join(" ",finalSet));
        }
    }
}
