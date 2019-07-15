using System;

namespace CustomColorsSounds
{
    public class Cessna : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }

        // public void RefuelTank() { Console.WriteLine("Refueling...."); }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes Reeeeeeee!");
        }

        public override void Turn()
        {
            Console.WriteLine($"I don't know what direction it turned, but {this.GetType().Name} is flying.");
        }
    }
}