using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {

        public bool HasToolbox { get; set; }

        public string TowBar { get; set; }

        public int NumberofWheels { get; set; }

        public string FuelIntake { get; set; }

        public string Seating { get; set; }

        public bool Afforadable { get; set; }

        public string Logo { get; set; }

        public string Headquarters { get; set; }



        public void DisplayDetails()
        {
            Console.WriteLine($"Truck has the following features: Has ToolBox: {HasToolbox}, " +
                $"Cost Afforadable: {Afforadable}, " +
                $"Company Headquarters: {Headquarters}");
            Console.WriteLine();
        }



    }




}
