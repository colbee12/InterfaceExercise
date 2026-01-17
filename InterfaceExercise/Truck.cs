using System;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public string bedSize { get; set; }
    public bool deisal { get; set; }

    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    
    
    public string Logo { get; set; }
    public int Price { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"Bed size: {bedSize}, model: {Model}, year: {Year} , is a deisal: {deisal}," +
                          $" NumberOfWheels: {NumberOfWheels}, NumberOfDoors: {NumberOfDoors}, Logo color: {Logo}," +
                          $" Price: {Price}");
    }
}