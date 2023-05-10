using System;

class Car
{
    public int ID { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public string BodyType { get; set; }
    public Engine Engine { get; set; }
    public int Weight { get; set; }

    public Car(int id, string make, string model, int year, decimal price, string bodyType, Engine engine, int weight)
    {
        ID = id;
        Make = make;
        Model = model;
        Year = year;
        Price = price;
        BodyType = bodyType;
        Engine = engine;
        Weight = weight;
    }

    public override string ToString()
    {
        return string.Format("| {0,3} | {1,-12} | {2,-11} | {3,-4} | {4,-11:C} | {5,-12} | {6,-11} | {7,-10} | {8,-9} | {9,-12} |",
                             ID, Make, Model, Year, Price, BodyType, Engine.Type, Engine.Horsepower, Engine.Kilowatts, Weight);
    }
}

class Engine
{
    public string Type { get; set; }
    public int Horsepower { get; set; }
    public int Kilowatts { get; set; }

    public Engine(string type, int horsepower, int kilowatts)
    {
        Type = type;
        Horsepower = horsepower;
        Kilowatts = kilowatts;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Engine fourCylinder = new Engine("4-cylinder", 0, 0);
        Engine v8 = new Engine("V8", 0, 0);

        Car[] cars = new Car[]
        {
            new Car(1, "Mazda", "MX-5", 2022, 41960M, "Convertible", new Engine(fourCylinder.Type, 181, 135), 1045),
            new Car(2, "Subaru", "WRX", 2022, 43490M, "Sedan", new Engine(fourCylinder.Type, 271, 202), 1572),
            new Car(3, "Ford", "Mustang", 2022, 62990M, "Coupe", new Engine(v8.Type, 460, 343), 1725),
            new Car(4, "Chevrolet", "Camaro", 2022, 85990M, "Coupe", new Engine(v8.Type, 455, 339), 1683),
            new Car(5, "Volkswagen", "Golf GTI", 2022, 58490M, "Hatchback", new Engine(fourCylinder.Type, 242, 180), 1399)
        };

        Console.WriteLine("| {0,-3} | {1,-12} | {2,-11} | {3,-4} | {4,-11} | {5,-12} | {6,-11} | {7,-10} | {8,-9} | {9,-12} |", "ID", "Make", "Model", "Year", "Price (AUD)", "Body Type", "Engine Type", "Horsepower", "Kilowatts", "Weight (kg)");

    }
}
