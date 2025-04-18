using System;
using System.Linq;

namespace CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int> CustomMin = (int[] n) =>
            {
                int min = int.MaxValue;
                for (int i = 0; i < n.Length; i++)
                {
                    if (min > n[i])
                    {
                        min = n[i];
                    }
                }
                return min;
            };
            Console.WriteLine(CustomMin(nums));
        }
    }
}
