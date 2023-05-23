using System;
using AT1.Models;

class Program
{
    static void Main(string[] args)
    {
        ListOfCars carsList = new();
        carsList.InsertData();

        //table for the data of cars 
        Console.WriteLine("| {0,-3} | {1,-12} | {2,-11} | {3,-4} | {4,-11} | {5,-12} | {6,-11} | {7,-10} | {9,-12} |", "ID", "Make", "Model", "Year", "Price (AUD)", "Body Type", "Engine Type", "Horsepower", "Weight (kg)");
        foreach (var car in carsList.Cars)
        {
            Console.WriteLine(car.Make);
        }

        Console.WriteLine("Sorting By Name...");
        carsList.OrderByName();

        foreach (var car in carsList.Cars)
        {
            Console.WriteLine(car.Make);
        }
    }

    public void Test() 
    {

    }
}
