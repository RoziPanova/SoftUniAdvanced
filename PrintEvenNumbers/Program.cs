using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> nums = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Console.WriteLine(string.Join(", ",nums.Where(x=>x%2==0)));
        }
    }
}
