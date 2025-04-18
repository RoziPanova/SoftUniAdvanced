using System;
using System.Collections.Generic;

namespace MatchingBrakets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int start = stack.Pop();
                    int end = i+1;
                    Console.WriteLine(input.Substring(start, end-start));
                }
            }
        }
    }
}
