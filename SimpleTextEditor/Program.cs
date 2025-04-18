using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            Stack<string> stack = new Stack<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(' ');
                if (commands[0] == "1")
                {
                    result += (commands[1]);
                    stack.Push(commands[1]);
                }
                else if (commands[0] == "2")
                {
                    result = result.Remove(result.Length - int.Parse(commands[1]), int.Parse(commands[1]));
                    stack.Push(result);
                }
                else if (commands[0] == "3")
                {
                    Console.WriteLine(result.ElementAt((int.Parse(commands[1]) - 1)));
                }
                else
                {
                   
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        result = "";
                    }
                    else
                    {
                        result = stack.Peek();
                    }
                }
            }
        }
    }
}
