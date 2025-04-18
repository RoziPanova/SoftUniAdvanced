using System;
using System.Linq;

namespace FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Predicate<int> IsEven = n => n % 2 == 0;
            var result = "";
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (command == "even" && IsEven(i)==true)
                {
                    result += i + " ";
                }
                else if (command == "odd" && IsEven(i)==false)
                {
                    result += i + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
