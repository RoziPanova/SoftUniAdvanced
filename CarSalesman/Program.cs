using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);
                int outValue = 0;
                int dissplacement = 0;
                string efficiency = "";
                if (input.Length == 2)
                {
                    engines.Add(new Engine(model, power, dissplacement, efficiency));
                    continue;
                }
                if (int.TryParse(input[2], out dissplacement) && input.Length == 4)
                {
                    efficiency = input[3];
                }
                else if (int.TryParse(input[2], out outValue) == false && input.Length == 3)
                {
                    efficiency = input[2];
                }
                engines.Add(new Engine(model, power, dissplacement, efficiency));
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engine = input[1];
                int outValue = 0;
                int weight = 0;
                string color = "";
                if (input.Length == 2)
                {
                    cars.Add(new Car(model, engines.FirstOrDefault(x => x.Model == engine), weight, color));
                    continue;
                }
                if (int.TryParse(input[2], out weight) && input.Length == 4)
                {
                    color = input[3];
                }
                else if (int.TryParse(input[2], out outValue) == false && input.Length == 3)
                {
                    color = input[2];
                }
                cars.Add(new Car(model, engines.FirstOrDefault(x => x.Model == engine), weight, color));
            }
            foreach (var item in cars)
            {
                var displacement = "";
                var efficiency = "";
                var weight = "";
                var color = "";
                if (item.Engine.Displacement == 0)
                {
                    displacement = "n/a";
                }
                else
                {
                    displacement = item.Engine.Displacement.ToString();
                }
                if (item.Engine.Efficiency == "")
                {
                    efficiency = "n/a";
                }
                else
                {
                    efficiency = item.Engine.Efficiency.ToString();
                }
                if (item.Weight == 0)
                {
                    weight = "n/a";
                }
                else
                {
                    weight = item.Weight.ToString();
                }
                if (item.Color == "")
                {
                    color = "n/a";
                }
                else
                {
                    color = item.Color.ToString();
                }
                Console.WriteLine($"{item.Model}:\n" +
                                  $"  {item.Engine.Model}:\n" +
                                  $"    Power: {item.Engine.Power}\n" +
                                  $"    Displacement: {displacement}\n" +
                                  $"    Efficiency: {efficiency}\n" +
                                  $"  Weight: {weight}\n" +
                                  $"  Color: {color}"
                    );
            }
        }
    }
}
