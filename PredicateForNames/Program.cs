using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Func<List<string>, List<string>> NameLenght = (List<string> names) =>
            {
                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i].Length > n)
                    {
                        names.RemoveAt(i);
                        i--;
                    }
                }
                return names;
            };
            NameLenght(names);
            Console.WriteLine(string.Join("\n", names));
        }
    }
}
