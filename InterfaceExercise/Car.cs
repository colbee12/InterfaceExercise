using System;

namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public bool hasTrunk { get; set; }
    public string Brand { get; set; }

    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    public string Logo { get; set; }
    public int Price { get; set; }
    
    
    public void DisplayDetails()
    {
        Console.WriteLine($"brand: {Brand}, model: {Model}, year: {Year} , hasTrunk: {hasTrunk}," +
                          $" NumberOfWheels: {NumberOfWheels}, NumberOfDoors: {NumberOfDoors}, Logo color: {Logo}," +
                          $" Price: {Price}");
    }

}