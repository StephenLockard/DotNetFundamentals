using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            CarRepo repo = new CarRepo();
            Vehicle car = new Vehicle();
            Console.WriteLine("Welcome to self Insurance Estimate App:\n -------------------");

            Console.WriteLine("Enter your vehicle Make:\n ------------------- \n");
            string vehicleMake = Console.ReadLine();

            Console.WriteLine("Enter your vehicle Model:\n ------------------- ");
            string vehicleModel = Console.ReadLine();

            Console.WriteLine("Enter your vehicle Year:\n ------------------- \n");
            bool isInt = int.TryParse(Console.ReadLine(), out int vehicleYear);

            Console.WriteLine("Enter your vehicle Type (Four door, sedan, truck, etc):\n ------------------- \n");
            string vehicleType = Console.ReadLine();

            Console.WriteLine("How many wheels does your vehicle have?");
            int numberOfWheels = int.Parse(Console.ReadLine());

            Console.WriteLine("Has it been in a collision? \n ------------------- \n");
            bool beenWrecked = bool.Parse(Console.ReadLine());

            Console.WriteLine("How many previous owners? \n ------------------- ");
            int howManyOwners = int.Parse(Console.ReadLine());

            if (isInt == true )
            {
                car.Make = vehicleMake;
                car.Year = vehicleYear;
                car.Model = vehicleModel;
                car.Type = vehicleType;
                car.NumberOfWheels = numberOfWheels;
                car.InvolvedInCollision = beenWrecked;
                car.PreviousOwners = howManyOwners;

                decimal insuranceTotal = repo.InsuranceCost(car);

                Console.WriteLine("The insurance cost for a " + vehicleYear + " "+ vehicleMake + " "+ vehicleModel + " "+ "with " + numberOfWheels + " wheels, with "+ beenWrecked + " collision history and "+ howManyOwners + " owners, is $"+ insuranceTotal);

                repo.AppendToList(car);
                List<Vehicle> carList = repo.GetListOfCars();
                Console.WriteLine(carList);
                Console.ReadKey();

            }

        }
    }
}
