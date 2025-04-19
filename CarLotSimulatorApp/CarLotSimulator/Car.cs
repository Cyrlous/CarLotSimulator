using System;
using System.Dynamic;

namespace CarLotSimulator;

public class Car
{
    public Car()
    {
        CarLot.numberOfCars++;
    }
    
    public Car(int year, string make, string model, string engineNoise, string honkNoise)
    {
        Year = year;
        Make = make;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        CarLot.numberOfCars++;
    }

    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        Console.WriteLine(engineNoise);
    }

    public void MakeHonkNoise(string honkNoise)
    {
        Console.WriteLine(honkNoise);
    }
}