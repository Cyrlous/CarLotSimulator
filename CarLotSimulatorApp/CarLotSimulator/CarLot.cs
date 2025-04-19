using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public CarLot()
    {
        
    }

    public static int numberOfCars = 0;
    public List<Car> CarList { get; set; } = new List<Car>();
    
    public void ListCars()
    {
        foreach (var car in CarList)
        {
            Console.WriteLine($"We have a {car.Year} {car.Make} {car.Model} for a great low price!");
        }
    }
}