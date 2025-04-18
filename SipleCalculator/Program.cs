using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>(input.Reverse());
            int result = int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                string opperation = stack.Pop();
                int currentNum = int.Parse(stack.Pop());
                if (opperation == "+")
                {
                    result += currentNum;
                }
                else if (opperation == "-")
                { result -= currentNum; }
            }
            Console.WriteLine(result);
        }
    }
}
