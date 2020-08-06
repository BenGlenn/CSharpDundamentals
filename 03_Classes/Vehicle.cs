using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat} // list on constant options/types
    public class Vehicle
    {
        // Constructor
        public Vehicle() { }
        public Vehicle(string make, string model, double mileage, VehicleType type) // These are peramters that must be met... 
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = type;

        }

        // properties
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
    }
}
