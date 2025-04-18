using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Reverse().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            Predicate<int> IsDevisible = num => num % n == 0;
            Func<List<int>, List<int>> remove = (List<int> nums) =>
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (IsDevisible(nums[i]))
                    {
                        nums.RemoveAt(i);
                        i--;
                    }
                }
                return nums;
            };
            remove(nums);
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
