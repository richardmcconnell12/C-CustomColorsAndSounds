using System;

namespace CustomColorsSounds
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn()
        {
            Console.WriteLine($"I don't know what direction it turned, but {this.GetType().Name} did.");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stop! In the name of love..");
        }
    }
}