﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instantiate the CarLot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var dansCarLot = new CarLot();
            
            var sedan = new Car()
            {
                Year = 2015,
                Make = "Audi",
                Model = "A6",
                EngineNoise = "Vroom",
                HonkNoise = "Honk!"
            };
            
            dansCarLot.CarList.Add(sedan);
            Console.WriteLine($"Number of cars on the lot is now {CarLot.numberOfCars}");

            var truck = new Car();
            truck.Year = 2016;
            truck.Make = "Ford";
            truck.Model = "F-150";
            truck.EngineNoise = "VRROOOOOM!";
            truck.HonkNoise = "HONK!";

            dansCarLot.CarList.Add(truck);
            Console.WriteLine($"Number of cars on the lot is now {CarLot.numberOfCars}");

            var hatchback = new Car(2019, "Nissan", "Rogue", "Vrrrrroom", "Beep!");
            
            dansCarLot.CarList.Add(hatchback);
            Console.WriteLine($"Number of cars on the lot is now {CarLot.numberOfCars}");
            
            dansCarLot.ListCars();
            
            sedan.MakeEngineNoise(sedan.EngineNoise);
            truck.MakeEngineNoise(truck.EngineNoise);
            hatchback.MakeEngineNoise(hatchback.EngineNoise);
            
            sedan.MakeHonkNoise(sedan.HonkNoise);
            truck.MakeHonkNoise(truck.HonkNoise);
            hatchback.MakeHonkNoise(hatchback.HonkNoise);
        }
    }
}
