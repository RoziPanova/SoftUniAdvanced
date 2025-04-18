
using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Cars
    {
        private string model;
        private double fuelAmount;
        private double fuelPerkm;
        private double distanceTraveled;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }
        public double FuelPerkm
        {
            get { return fuelPerkm; }
            set { fuelPerkm = value; }
        }
        public double DistanceTraveled
        {
            get { return distanceTraveled; }
            set { distanceTraveled = value; }
        }
        public Cars(string model, double fuelAmount, double fuelPerkm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelPerkm = fuelPerkm;
        }
        public void Travel(double distanceTraveled)
        {
            double fuleConsumed = distanceTraveled * fuelPerkm;
            if (fuelAmount - fuleConsumed < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
            }
            fuelAmount -= fuleConsumed;
            this.distanceTraveled += distanceTraveled;
        }
    }
}
