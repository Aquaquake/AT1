using System;
using AT1.Models;

class Program
{
    static void Main(string[] args)
    {
       
      ListOfCars listOfCars = new ListOfCars();
            listOfCars.InsertData();

            // Call the PrintCar function
            listOfCars.PrintCar();  
    }
}
