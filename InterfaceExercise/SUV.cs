using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {

        public int NumberOfSeats { get; set; }

        public string Model { get; set; }

        public int NumberofWheels { get; set; }

        public string FuelIntake { get; set; }

        public string Seating { get; set; }

        public bool Afforadable { get; set; }

        public string Logo { get; set; }

        public string Headquarters { get; set; }



        public void DisplayDetails()
        {
            Console.WriteLine($"SUV has the following features: Seating Capacity: {NumberOfSeats}, " +
                $"SUV Model: {Model}, " +
                $"Seating Type: {Seating}");
        }





    }





}
