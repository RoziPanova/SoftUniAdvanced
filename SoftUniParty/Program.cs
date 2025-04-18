using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input=="PARTY")
                {
                    while ((input = Console.ReadLine()) != "END")
                    {
                        if (char.IsDigit(input.First()))
                        {
                            VIP.Remove(input);
                        }
                        else
                        {
                            guests.Remove(input);
                        }
                    }
                    break;
                }
                else
                {
                    if (char.IsDigit(input.First()))
                    {
                        VIP.Add(input);
                    }
                    else
                    {
                        guests.Add(input);
                    }
                }
            }
            Console.WriteLine(VIP.Count+guests.Count);
            foreach (var item in VIP)
            {
                Console.WriteLine(item);
            }
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
