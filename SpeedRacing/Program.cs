using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Cars> list = new List<Cars>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Cars car = new Cars(input[0], double.Parse(input[1]), double.Parse(input[2]));
                list.Add(car);
            }
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] tokens = line.Split();
                Cars current = list.FirstOrDefault(x => x.Model == tokens[1]);
                current.Travel(double.Parse(tokens[2]));
            }
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.DistanceTraveled}");
            }
        }
    }
}
/*
3
AudiA4 18 0,34
BMW-M2 33 0,41
Ferrari-488Spider 50 0,47
Drive Ferrari-488Spider 97
Drive Ferrari-488Spider 35
Drive AudiA4 85
Drive AudiA4 50
End
 */
