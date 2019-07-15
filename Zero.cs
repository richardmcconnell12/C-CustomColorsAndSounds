using System;

namespace CustomColorsSounds
{
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        // public void ChargeBattery() { Console.WriteLine("Charging battery...."); }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero makes a silent BRRRRAP sound.");
        }

        public override void Turn()
        {
            Console.WriteLine($"I don't know what direction it turned, but {this.GetType().Name} is popping sick wheelies.");
        }
    }
}