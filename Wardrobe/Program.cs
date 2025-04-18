using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dic = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();
                string[] clothes = input[1].Split(",");
                if (dic.ContainsKey(input[0]) == false)
                {
                    dic.Add(input[0], new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (dic[input[0]].ContainsKey(clothes[j]) == false)
                    {

                        dic[input[0]].Add(clothes[j], 1);

                    }
                    else
                    {
                        dic[input[0]][clothes[j]]++;
                    }
                }
            }
            string[] search = Console.ReadLine().Split(" ");
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var s in item.Value)
                {
                    if (item.Key == search[0] && s.Key == search[1])
                    {
                        Console.WriteLine($"* {s.Key} - {s.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {s.Key} - {s.Value}");
                    }
                }
            }
        }
    }
}
