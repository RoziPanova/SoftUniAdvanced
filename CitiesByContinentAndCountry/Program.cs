using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> dictionary = new Dictionary<string, Dictionary<string, List<string>>>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[]input=Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (dictionary.ContainsKey(continent) == false)
                {
                    dictionary.Add(continent, new Dictionary<string, List<string>>());
                    dictionary[continent].Add(country, new List<string>() { city });
                }
                else if (dictionary[continent].ContainsKey(country)==false)
                {
                    dictionary[continent].Add(country, new List<string>() { city });
                }
                else
                {
                    dictionary[continent][country].Add(city);
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var country in item.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
