using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany (DONE)

            //Create 3 classes called Car , Truck , & SUV  (DONE)

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }     (DONE)
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }    (DONE)
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }   (DONE)
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.  (DONE)
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values


            Car car1 = new Car();
            car1.HasTrunk = true;
            car1.HasLicensePlate = true;
            car1.NumberofWheels = 4; /// finish with remaing members
            car1.FuelIntake = "gasoline";
            car1.Seating = "bench";
            car1.Afforadable = true;
            car1.Logo = "triangle";
            car1.Headquarters = "Detroit";



            Truck truck1 = new Truck   /// use object initilizer syntax 
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



            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.


            car1.DisplayDetails();
            truck1.DisplayDetails();
            suv1.DisplayDetails();

        }
    }
}
