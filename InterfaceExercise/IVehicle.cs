using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {

        public int NumberofWheels { get; set; }

        public string FuelIntake { get; set; }

        public string Seating { get; set; }

        public bool Afforadable {  get; set; }

        void DisplayDetails();




    }




}
