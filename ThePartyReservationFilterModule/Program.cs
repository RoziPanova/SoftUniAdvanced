using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePartyReservationFilterModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            List<string> changes = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "Print")
            {
                var tokens = input.Split(';');
                var names = Filter(tokens[1], tokens[2]);
                if (tokens[0] == "Add filter")
                {
                    changes.AddRange(list.FindAll(names));
                    list.RemoveAll(names);
                }
                else if (tokens[0] == "Remove filter")
                {
                    var removedFilter=changes.FindAll(names);
                    list.AddRange(removedFilter);
                }
            }
            if (list.Count != 0)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
        public static Predicate<string> Filter(string filterType, string filterParameter)
        {
            switch (filterType)
            {
                case "Starts with":
                    return names => names.StartsWith(filterParameter);
                case "Ends with":
                    return names => names.EndsWith(filterParameter);
                case "Length":
                    return names => names.Length == int.Parse(filterParameter);
                case "Contains":
                    return names => names.Contains(filterParameter);
                default: return null;
            }
        }
    }
}
