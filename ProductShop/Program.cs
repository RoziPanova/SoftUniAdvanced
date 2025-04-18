using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shop = new Dictionary<string, Dictionary<string, double>>();
            string input;
            while ((input=Console.ReadLine())!="Revision")
            {
                string[]tokens=input.Split(", ");
                if (shop.ContainsKey(tokens[0])==false)
                {
                    shop.Add(tokens[0], new Dictionary<string, double>());
                    shop[tokens[0]].Add(tokens[1], double.Parse(tokens[2]));
                }
                else
                {
                    shop[tokens[0]].Add(tokens[1], double.Parse(tokens[2]));
                }
            }
            var ordered=shop.OrderBy(x => x.Key);
            foreach (var items in ordered)
            {
                Console.WriteLine($"{items.Key}->");
                foreach (var product in items.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
