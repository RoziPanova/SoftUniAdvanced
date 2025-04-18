using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            string input;
            while ((input=Console.ReadLine())!="End")
            {
                if (input!="Paid")
                {
                    names.Enqueue(input);
                }
                else
                {
                    Console.WriteLine(string.Join("\n",names));
                    names.Clear();
                }
            }
            if (names.Count>=0)
            {
                Console.WriteLine($"{names.Count} people remaining.");
            }
        }
    }
}
