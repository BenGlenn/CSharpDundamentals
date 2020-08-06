using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // New up my Vehicle Instance
            Vehicle firstVehicle = new Vehicle(); //this is a constructor method

            //Setting Make property in my firstVehicle instance
            firstVehicle.Make = "Honda";
            Console.WriteLine(firstVehicle);

            Console.ReadLine();

            // Getting my Make property from firstVehicle and writing to the console
            Console.WriteLine(firstVehicle.Make);

            // setting the rest of the porperties
            firstVehicle.Model = "Civic";
            firstVehicle.Mileage = 12345.67d;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Vehicle car = new Vehicle("Toyota", "Corolla", 213000, VehicleType.Car);
            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 4009090, VehicleType.Spaceship);

            Person instrurctor = new Person();
            instrurctor.FirstName = "Ben";
            instrurctor.LastName = "Glenn";

            Console.WriteLine(instrurctor.FullName);

            instrurctor.DateOfBirth = new DateTime(1991, 9, 11);
            Console.WriteLine(Age);

            instrurctor.Transport = rocket;

            Console.WriteLine(instrurctor.Transport.TypeOfVehicle);


            Person student = new Person();
            student.FirstName = "Wes";
            student.LastName = "Winn";

            instrurctor.SayHello();
            instrurctor.SayHello(student.FirstName);
            instrurctor.SayHello();

        }
    }
}
}
