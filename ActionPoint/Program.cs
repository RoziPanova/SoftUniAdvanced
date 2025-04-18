using System;

namespace ActionPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            Action<string[]> print = message => Console.WriteLine(string.Join("\n", message));
            print(names);
        }
    }
}
