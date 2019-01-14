using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Challenge
{
    public class CarRepo
    {
        public decimal InsuranceCost(Vehicle car) //(Vehicle // car ) = (reference type // name)
        {
            decimal totalCost = 0m;

            if (car.Year > 1960 && car.Year <= 1970)
            {
                totalCost = 50m;
            }

            else if (car.Year > 1970 && car.Year <= 1980)
            {
                totalCost = 50m;
            }
            else if (car.Year > 1980 && car.Year <= 1991)
            {
                totalCost = 150m;
            }
            else
            {
                totalCost = 200m;
            }

            return totalCost;
        }

        List<Vehicle> listOfCars = new List<Vehicle>();

        public void AppendToList(Vehicle car)
        {
            listOfCars.Add(car);
        }

        public List<Vehicle> GetListOfCars()
        {
            return listOfCars;
        }
    }
}
