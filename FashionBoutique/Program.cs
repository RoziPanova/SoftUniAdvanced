using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity=int.Parse(Console.ReadLine());
            int racksUsed = 0;
            int currentSum = 0;
            while (clothes.Count>0)
            {
               
                if (currentSum + clothes.Peek() > rackCapacity)
                {
                    racksUsed++;
                    currentSum = 0;
                }
                //else
                //{
                //    racksUsed++;
                //}
                currentSum += clothes.Pop();
            }
            if (currentSum!=0)
            {
                racksUsed++;
            }
            Console.WriteLine(racksUsed);
        }
    }
}

