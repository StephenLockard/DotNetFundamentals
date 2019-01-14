using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Challenge
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public int NumberOfWheels { get; set; }
        public bool InvolvedInCollision { get; set; }
        public int PreviousOwners { get; set; }

        public Vehicle(string make, string model, int year, string type, int numberOfWheels, bool involvedInCollision, int previousOwners)
        {
            Make = make;
            Model = model;
            Year = year;
            Type = type;
            NumberOfWheels = numberOfWheels;
            InvolvedInCollision = involvedInCollision;
            PreviousOwners = previousOwners;
        }

  
        public Vehicle()
        {

        }
    }
}
