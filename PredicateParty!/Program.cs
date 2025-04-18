using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace PredicateParty_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var namesList = Console.ReadLine().Split().ToList();

            string input;
            while ((input = Console.ReadLine()) != "Party!")
            {
                var tokens = input.Split().ToList();

                var name = ReturnName(tokens[1], tokens[2]);

                switch (tokens[0])
                {
                    case "Remove":
                        namesList.RemoveAll(name);
                        break;
                    case "Double":
                        {
                            var matches = namesList.FindAll(name);
                            if (matches.Count > 0)
                            {
                                var index = namesList.FindIndex(name);
                                namesList.InsertRange(index, matches);
                            }

                            break;
                        }
                }
            }

            if (namesList.Count != 0)
            {
                Console.WriteLine(string.Join(", ", namesList) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> ReturnName(string command, string value)
        {
            switch (command)
            {
                case "StartsWith":
                    return (name) => name.StartsWith(value);
                case "EndsWith":
                    return (name) => name.EndsWith(value);
                case "Length":
                    return (name) => name.Length == int.Parse(value);
                default:
                    return null;
            }
        }
    }
}
