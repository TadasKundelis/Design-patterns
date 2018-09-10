using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vehicleFactory = null;
            Console.WriteLine("Enter the vehicle type (either car or truck): ");
            string vehicleType = Console.ReadLine();
            switch(vehicleType.ToLower())
            {
                case "car":
                    vehicleFactory = new CarFactory("red", "40000$");
                    break;
                case "truck":
                    vehicleFactory = new TruckFactory("white", "100000$");
                    break;
                default:
                    break;
            }
            if (vehicleFactory != null)
            {
                Vehicle vehicle = vehicleFactory.CreateVehicle();
                Console.WriteLine("Vehicle Type: {0}", vehicle.Type);
                Console.WriteLine("Vehicle Color: {0}", vehicle.Color);
                Console.WriteLine("Vehicle Price: {0}", vehicle.Price);
            }
            else
            {
                Console.WriteLine("invalid vehicle type selected");
            }
            Console.ReadKey();
        }
    }
}
