using System;
using System.Reflection;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new CarLot();
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var myOldCar = new Car();
            myOldCar.Make = "chevy";
            myOldCar.Model = "impala";
            myOldCar.Year = 2004;
            myOldCar.EngineNoise = "vroom";
            myOldCar.HonkNoise = "beep";
            myOldCar.IsDrivable = false;

            lot.Cars.Add(myOldCar);

            var joshesCar = new Car()
            {
                Make = "ford",
                Model = "f150",
                Year = 2017,
                EngineNoise = "rumble",
                HonkNoise = "booop",
                IsDrivable = true
            };

            lot.Cars.Add(joshesCar);

            var myNewCar = new Car(2019, "subaru", "legacy", "grumble", "eeep", true);

            lot.Cars.Add(myNewCar);

            myOldCar.MakeEngineNoise();
            joshesCar.MakeEngineNoise();
            myNewCar.MakeEngineNoise();

            myOldCar.MakeHonkNoise("beep");
            joshesCar.MakeHonkNoise("booop");
            myNewCar.MakeHonkNoise("eeep");
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
