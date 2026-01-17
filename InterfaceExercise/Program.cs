

using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            
            

           

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 *///done

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

            Car car = new Car()
            {
                hasTrunk = false,
                Year = 2010,
                Brand = "BMW",
                Logo = "blue and White",
                NumberOfDoors = 2,
                NumberOfWheels = 4,
                Price = 20000,
            };

            Truck truck = new Truck()
            {
                bedSize = "5ft",
                deisal = true,
                Model = "Raptor",
                Year = 2020,
                NumberOfWheels = 4,
                NumberOfDoors = 2,
                Logo = "green and White",
                Price = 26000
            };

            Suv suv = new Suv()
            {
                rowsOFSeats = 3,
                HasSunroof = true,
                Model = "Range Rover",
                Year = 2022,
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                Logo = "orange and black",
                Price = 30000
            };
            Console.WriteLine("The Car");
            car.DisplayDetails();
            Console.WriteLine("The truck");
            truck.DisplayDetails();
            Console.WriteLine("The SUV");
            suv.DisplayDetails();















        }
    }
}
