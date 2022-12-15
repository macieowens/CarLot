using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
            
        public Car(int year, string made, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
        }

        public int Year { get; set; }
        public string Make1 { get; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public bool IsDrivable { get; set; }
        public string HonkNoise { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(HonkNoise);
        }

        
    }

}
