using System;

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
            Car Mers = new Car();
            
            Mers.Make = "Mersedes-Benz";
            Mers.Year = 2022;
            Mers.Model = "SL 50";
            Mers.IsDriveable =  true;
            Mers.EngineNoise = "drrrrr";
            Mers.HonkNoise = "Tut tut";
            
            Console.WriteLine("----------------FIRST CAR-----------------------");
            Console.WriteLine($"{Mers.Make} {Mers.Year} year model {Mers.Model},  is running great! Engine noise: {Mers.EngineNoise}, when you honk - {Mers.HonkNoise}!");
            Console.WriteLine("----------------SECOND CAR-----------------------");
            
            Car BMW = new Car()
            {
                Make = "BMW",
                Year = 2024,
                Model = "M6",
                IsDriveable = true,
                EngineNoise = "Rrrrrr rrrr",
                HonkNoise =  "Tit tut tit"
            };
            
            Console.WriteLine($"Look this is {BMW.Make} model {BMW.Model} {BMW.Year} year! it is running {BMW.IsDriveable}! Engine noise: {BMW.EngineNoise}, when you honk - {BMW.HonkNoise}!");
            Console.WriteLine("----------------THIRD CAR-----------------------");

            Car Nissan = new Car();
            Console.WriteLine($"This is {Nissan.Make} model {Nissan.Model} {Nissan.Year} year! is it running {Nissan.IsDriveable}! Engine noise: {Nissan.EngineNoise}, when you honk - {Nissan.HonkNoise}!");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            var lot = new Carlot();
            // var carDet = new Car();
            lot.Cars.Add(BMW);
            lot.Cars.Add(Nissan);
            lot.Cars.Add(Mers);
            
            lot.AddCar();
            
        }
    }
}
