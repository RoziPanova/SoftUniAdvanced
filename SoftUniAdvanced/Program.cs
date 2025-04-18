using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>(Console.ReadLine().ToCharArray());
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
