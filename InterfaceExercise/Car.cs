using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany 
    {
        public bool HasTrunk { get; set; }

        public bool HasLicensePlate { get; set; }
        public int NumberofWheels { get; set; }

        public string FuelIntake { get; set; }

        public string Seating { get; set; }

        public bool Afforadable { get; set; }

        public string Logo { get; set; }

        public string Headquarters { get; set; }




        public void DisplayDetails()
        {
            Console.WriteLine($"Car has the following features: Has TrunK: {HasTrunk}, Fuel Type: {FuelIntake}, Car Logo: {Logo}");
            Console.WriteLine();
        }
    }




}
