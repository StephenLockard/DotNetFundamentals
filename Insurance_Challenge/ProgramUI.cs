﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Challenge
{
    public class ProgramUI
    {
        private Customer _customer;
        private VehicleRepository _vehicleRepo;

        public ProgramUI()
        {
            _customer = new Customer();
        }

        public void Run()

        {
            bool running = true;
            while (running)
            Console.Clear();
            Register();
            Console.WriteLine(" what would you like to do?" +
                "1. View Information\n" +
                "2.Update Information\n" +
                "3.Register a Vehicle\n" +
                "4. Exit application");
            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);

            switch (input)

            {
                case 1:
                    //ViewInformation();
                    break;
                case 2:
                    Register();
                    break;
                case 3:
                    RegisterVehicle();
                    break;
                case 4:
                    //ExitApplication();
                    break;
                    {

                    }

            }
        }
        private void Register()
        {
            Console.WriteLine("Enter your Name:");
            _customer.FullName = Console.ReadLine();

            Console.WriteLine(" Enter your age please:");
            string ageAsString = Console.ReadLine();
            _customer.Age = int.Parse(ageAsString);

            Console.WriteLine("Enter your gender:" +
                "1) Male 2) Female 3) Other");
            string genderAsString = Console.ReadLine().ToLower();
            switch (genderAsString)
            {
                case "Male":
                case "1":
                    _customer.Gender = GenderType.Male;
                    break;
                case "female":
                case "2":
                    _customer.Gender = GenderType.Female;
                    break;
                case "other":
                case "3":
                    _customer.Gender = GenderType.Other;
                    break;

            }


        }
        private void RegisterVehicle()

        // make,model,year, and mileage
        {
            Console.WriteLine("Enter the vehicle make:");
            string make = Console.ReadLine();

            Console.WriteLine("Enter the vehicle model:");
            string model = Console.ReadLine();

            Console.WriteLine("Enter the vehicle year:");
            string yearAsString = Console.ReadLine();
            int year = int.Parse(yearAsString);

            Console.WriteLine("Enter the vehicle mileage:");
            string mileageAsString = Console.ReadLine();
            int mileage = int.Parse(mileageAsString);

            Vehicle newVechicle = new Vehicle(make, model, year, mileage);
            _vehicleRepo.AddVehicleToList(newVechicle);
        }
        //private void ViewInformation()
        //{
        //    List<Vehicle> list = _vehicleRepo.GetVehicleList();

        //    foreach (Vehicle vehicle in list)

        //        Console.WriteLine($"{vehicle.Make} {vehicle.Mileage} {vehicle.Model}");
        //        {
        //        Console.ReadKey();
        //    }
        //        decimal total = 0;
        //        decimal premium = _vehicleRepo.CalculateVehiclePremium(vehicle);
        //        total = total + premium; //total +=premium;

        //        Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model} ${premium}" );
        //    }
    }
}
