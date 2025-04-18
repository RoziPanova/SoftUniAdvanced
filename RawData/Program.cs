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
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                List<Tires> tires = new List<Tires>();
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = info[0];
                int speed = int.Parse(info[1]);
                int power = int.Parse(info[2]);
                int weight = int.Parse(info[3]);
                string type = info[4];
                float pressure1 = float.Parse(info[5]);
                int age1 = int.Parse(info[6]);
                tires.Add(new Tires(age1, pressure1));
                float pressure2 = float.Parse(info[7]);
                int age2 = int.Parse(info[8]);
                tires.Add(new Tires(age2, pressure2));
                float pressure3 = float.Parse(info[9]);
                int age3 = int.Parse(info[10]);
                tires.Add(new Tires(age3, pressure3));
                float pressure4 = float.Parse(info[11]);
                int age4 = int.Parse(info[12]);
                tires.Add(new Tires(age4, pressure4));
                Car car = new Car(model, new Engine(speed, power), new Cargo(type, weight), tires);
                cars.Add(car);
            }
            string cargoType = Console.ReadLine();
            if (cargoType == "fragile")
            {
                var frigileCargo = cars.Where(x => x.Cargo.CargoType == "fragile");
                foreach (var item in frigileCargo)
                {
                    if (item.Tires.Where(x => x.Pressure > 1).Count() == 1)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
            else if (cargoType == "flammable")
            {
                var flammableCargo = cars.Where(x => x.Cargo.CargoType == "flammable");
                foreach (var item in flammableCargo)
                {
                    if (item.Engine.Power > 250)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
        }
    }
}
