using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool flag=true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    stack.Push(input[i]);
                    continue;
                }
                if(stack.Count==0) 
                {
                    flag=false; break;
                }
                if (input[i] == ')' && stack.Peek() == '(' || input[i] == ']' && stack.Peek() == '[' || input[i] == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else
                {
                    flag = false;
                    break;
                }

            }
            if (flag)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
