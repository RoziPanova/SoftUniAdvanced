using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            string input;
            while ((input=Console.ReadLine().ToLower()) != "end")
            {
                string[]commands=input.Split();
                if (commands[0]=="add")
                {
                    stack.Push(int.Parse(commands[1]));
                    stack.Push(int.Parse(commands[2]));
                }
                else if (commands[0]=="remove")
                {
                    if (int.Parse(commands[1])>stack.Count)
                    {
                        continue;
                    }
                    for (int i = 0; i < int.Parse(commands[1]); i++)
                    {
                       stack.Pop();
                    }
                }
            }
            int sum = 0;
            foreach (int i in stack)
            { sum += i; }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
/*
3 5 8 4 1 9
add 19 32
remove 10
add 89 22
remove 4
remove 3
end
 */

