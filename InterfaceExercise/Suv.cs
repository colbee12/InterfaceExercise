using System;

namespace InterfaceExercise;

public class Suv : IVehicle, ICompany
{
    public int rowsOFSeats { get; set; }
    public bool HasSunroof { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    
    
    public string Logo { get; set; }
    public int Price { get; set; }
    
    
    public void DisplayDetails()
    {
      Console.WriteLine($"has sun roof: {HasSunroof}, model: {Model}, year: {Year} , rowsOFSeats: {rowsOFSeats}" + 
                 $" NumberOfWheels: {NumberOfWheels}, NumberOfDoors: {NumberOfDoors}, Logo color: {Logo}," +
                 $" Price: {Price}");
    }
}