using System;

namespace CustomColorsSounds
{
    public class Ram : Vehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }

        // public void RefuelTank() { Console.WriteLine("Refueling...."); }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram goes vroooooooom!");
        }

        public override void Stop()
        {
            Console.WriteLine("Dodge the stopped Ram");
        }
    }
}