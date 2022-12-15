using System;
using System.ComponentModel;

namespace CarLotSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var maciesCar = new Car()
            {
                Year = 1998,
                Model = "Wrangler",
                EngineNoise = "LOUD",
                HonkNoise = "annoying",
                IsDrivable = true,
            };

            var momsCar = new Car()
            {
                Year = 2020,
                Model = "Toyota",
                EngineNoise = "Moderate",
                HonkNoise = "quiet",
                IsDrivable= true,
            };

            var dadsCar = new Car()
            {
                Year = 1850,
                Model = "Ford",
                EngineNoise = "nonexistent",
                HonkNoise = "old timey",
                IsDrivable = false,
            };

            Console.WriteLine($"Number of Cars created: {CarLot.numberOfCars}");
        }
    }
}
