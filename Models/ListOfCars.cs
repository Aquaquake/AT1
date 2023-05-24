using System.Collections.Generic;

namespace AT1.Models;

public class ListOfCars
{
    public List<CarModel> Cars { get; set; }

    public ListOfCars()
    {
        Cars = new();    
    }

    public void InsertData() 
    {
        Cars.Add(new CarModel(1, "Mazda", "MX-5", 2022, 41960M, "Convertible", 181, 1045, 135));
        Cars.Add(new CarModel(2, "Subaru", "WRX", 2022, 43490M, "Sedan", 271, 1572, 202));
        Cars.Add(new CarModel(3, "Ford", "Mustang", 2022, 62990M, "Coupe", 460, 1725, 343));
        Cars.Add(new CarModel(4, "Chevrolet", "Camaro", 2022, 85990M, "Coupe", 455, 1683, 339));
        Cars.Add(new CarModel(5, "Volkswagen", "Golf GTI", 2022, 58490M, "Hatchback", 242, 1399, 180));
    }

    public void OrderByName()
    {
        Cars = Cars.OrderBy(c => c.Make).ToList();
    }

    public void SortByBodyType() 
    {
        Cars = Cars.OrderBy(c => c.BodyType).ToList();
    }

    public void PrintCars()
    {
        Console.WriteLine("| {0,-3} | {1,-12} | {2,-11} | {3,-4} | {4,-12 } | {5,-12} | {6,-11} | {7,-10} | {8,-6} |",
        "ID", "Make", "Model", "Year", "Price (AUD)", "Body Type", "Weight (kg)", "Horsepower", "Kilowatts");
        

        foreach (CarModel car in Cars)
        {
            ///("| {0,-3} | {1,-12} | {2,-11} | {3,-4} | {4,-11} | {5,-12} | {6,-11} | {7,-10} | {8,-9} | {9,-12} |"
            
            Console.WriteLine("| {0,-3} | {1,-12} | {2,-11} | {3,-4} | ${4,-11} | {5,-12} | {6,-11} | {7,-10} | {8,-9} |",
            car.ID, car.Make, car.Model, car.Year, car.Price.ToString("F2"), car.BodyType, car.Weight, car.Horsepower, car.Kilowatts);

        }
    }
}