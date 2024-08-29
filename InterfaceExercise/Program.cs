using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            car1.HasTrunk = true;
            car1.HasLicensePlate = true;
            car1.NumberofWheels = 4; 
            car1.FuelIntake = "gasoline";
            car1.Seating = "bench";
            car1.Afforadable = true;
            car1.Logo = "triangle";
            car1.Headquarters = "Detroit";



            Truck truck1 = new Truck   /// Used Object Initilizer Syntax 
            {
                HasToolbox = true,
                TowBar = "Front",
                NumberofWheels = 6,
                FuelIntake = "Gravity",
                Seating = "Front",
                Afforadable = true,
                Logo = "square",
                Headquarters = "ohio",


            };


            SUV suv1 = new SUV();
            suv1.NumberOfSeats = 8;
            suv1.Model = "Off road";
            suv1.NumberofWheels = 4; 
            suv1.FuelIntake = "gasoline";
            suv1.Seating = "bench";
            suv1.Afforadable = true;
            suv1.Logo = "triangle";
            suv1.Headquarters = "Detroit";


            car1.DisplayDetails();
            truck1.DisplayDetails();
            suv1.DisplayDetails();

        }
    }
}
