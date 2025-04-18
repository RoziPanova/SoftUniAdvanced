using System;

namespace TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ');
            Func<string, int, bool> sumOfChars = (name, n) =>
            {
                int sum = 0;
                foreach (char letter in name)
                {
                    sum += letter;
                }
                if (sum >= n)
                {
                    return true;
                }
                return false;
            };
            Func<string[], Func<string, int, bool>, string> ReturnName = (names, flag) =>
            {
                foreach (var name in names)
                {
                    if (flag(name, n) == true)
                    {
                        return name;
                    }
                }
                return null;
            };
            Console.WriteLine(string.Join(" ", ReturnName(names, sumOfChars)));
        }
    }
}