using System;

namespace CustomColorsSounds
{
    public class Tesla : Vehicle
    {  // Electric car
        public double BatteryKWh { get; set; }

        // public void ChargeBattery() { Console.WriteLine("Charging battery...."); }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla is silently purring!");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stop! In the name of Elon Musk..");
        }
    }
}