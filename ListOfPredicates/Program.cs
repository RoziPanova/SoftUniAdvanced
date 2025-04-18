using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] deviders = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Predicate<int> IsDevisible = (num) =>
            {
                bool flag = true;
                for (int i = 0; i < deviders.Length; i++)
                {
                    if (num % deviders[i] != 0)
                    {
                        flag = false;
                    }
                }
                return flag;
            };
            Func<int, int[]> findNums = n =>
            {
                List<int> list = new List<int>();
                for (int i = 1; i <= n; i++)
                {
                    if (IsDevisible(i))
                    {
                        list.Add(i);
                    }
                }
                return list.ToArray();
            };

            Console.WriteLine(string.Join(" ", findNums(n)));
        }
    }
}
