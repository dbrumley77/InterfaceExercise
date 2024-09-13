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
            car1.FuelIntake = "Gasoline";
            car1.Seating = "Bench";
            car1.Afforadable = true;
            car1.Logo = "Triangle";
            car1.Headquarters = "Detroit";



            Truck truck1 = new Truck   /// Used Object Initilizer Syntax 
            {
                HasToolbox = true,
                TowBar = "Front",
                NumberofWheels = 6,
                FuelIntake = "Gravity",
                Seating = "Front",
                Afforadable = true,
                Logo = "Square",
                Headquarters = "Ohio",


            };


            SUV suv1 = new SUV();
            suv1.NumberOfSeats = 8;
            suv1.Model = "Off Road";
            suv1.NumberofWheels = 4; 
            suv1.FuelIntake = "Gasoline";
            suv1.Seating = "Bench";
            suv1.Afforadable = true;
            suv1.Logo = "Triangle";
            suv1.Headquarters = "Detroit";


            car1.DisplayDetails();
            truck1.DisplayDetails();
            suv1.DisplayDetails();

        }
    }
}
