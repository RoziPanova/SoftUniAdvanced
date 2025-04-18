using System;
using System.Collections.Generic;

namespace ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            string input;
            while ((input=Console.ReadLine())!="END")
            {
                string[] tokens = input.Split(", ");
                string direction = tokens[0];
                string plateNum = tokens[1];
                if (direction=="IN")
                {
                    set.Add(plateNum);
                }
                else
                {
                    set.Remove(plateNum);
                }
            }
            if (set.Count>0)
            {
                Console.WriteLine(string.Join("\n",set));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
