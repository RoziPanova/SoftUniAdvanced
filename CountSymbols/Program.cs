using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            Dictionary<char,int>dic= new Dictionary<char,int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (dic.ContainsKey(input[i])==false)
                {
                    dic.Add(input[i], 1);
                }
                else
                {
                    dic[input[i]]++;
                }
            }
            var ordered=dic.OrderBy(x => x.Key);
            foreach (var item in ordered)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
