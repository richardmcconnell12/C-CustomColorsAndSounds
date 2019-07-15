using System;

namespace CustomColorsSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            var Cessna = new Cessna()
            {
                MainColor = "orange",
                MaximumOccupancy = 6,
                FuelCapacity = 2.7
            };

            var Ram = new Ram()
            {
                MainColor = "blue",
                MaximumOccupancy = 5,
                FuelCapacity = 2.3
            };

            var Tesla = new Tesla()
            {
                MainColor = "white",
                MaximumOccupancy = 8,
                BatteryKWh = 4.3
            };

            var Zero = new Zero()
            {
                MainColor = "black",
                MaximumOccupancy = 2,
                BatteryKWh = 4.8
            };

            Cessna.Drive();
            Cessna.Turn();
            Cessna.Stop();
            Ram.Drive();
            Ram.Turn();
            Ram.Stop();
            Tesla.Drive();
            Tesla.Turn();
            Tesla.Stop();
            Zero.Drive();
            Zero.Turn();
            Zero.Stop();
        }
    }
}
