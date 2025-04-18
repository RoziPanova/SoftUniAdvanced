using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Cargo
    {
        private string cargoType;
        private int weight;
        public string CargoType { get { return cargoType; } set { cargoType = value; } }
        public int Weight { get { return weight; } set { weight = value; } }
        public Cargo(string type, int weight)
        {
            this.cargoType = type;
            this.weight = weight;
        }
    }
}
