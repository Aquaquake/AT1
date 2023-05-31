namespace AT1.Models;

public class CarModel
{
    public int ID { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public string BodyType { get; set; }
    public int Weight { get; set; }
    public int Horsepower { get; set; }
    public int Kilowatts {get; set;}

    public CarModel(int id, string make, string model, int year, decimal price, string bodyType, int weight, int horsepower, int kilowatts)
    {
        ID = id;
        Make = make;
        Model = model;
        Year = year;
        Price = price;
        BodyType = bodyType;
        Weight = weight;
        Horsepower = horsepower;
        Kilowatts = kilowatts;
    }   

    public override string ToString()
    {
        return string.Format("| {0,3} | {1,-12} | {2,-11} | {3,-4} | {4,-11:C} | {5,-12} | {6,-11} | {7,-10} | {8,-9} | {9,-12} | {10,-6} |", ID, Make, Model, Year, Price, BodyType, Weight, Horsepower, Kilowatts);
    }

    
} 