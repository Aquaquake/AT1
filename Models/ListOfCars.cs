using System;
using System.Collections.Generic;

namespace AT1.Models
{
    // Collection of car
    public class ListOfCars
    {
        private List<FindCar.Car> _cars; // Private field to store a list of cars

        // Constructor
        public ListOfCars()
        {
            _cars = new List<FindCar.Car>(); // Initializing the list of cars
        }
        //this is the information that the code uses 
        public void InsertData()
        {
            // Inserting initial car data into the list
            _cars.Add(new FindCar.Car { Id = 1, Make = "Mazda", Model = "MX-5", Year = 2022, Price = 41960.00m, BodyType = "Convertible", Weight = 1045, Horsepower = 181, Kilowatts = 135 });
            _cars.Add(new FindCar.Car { Id = 2, Make = "Subaru", Model = "WRX", Year = 2022, Price = 43490.00m, BodyType = "Sedan", Weight = 1572, Horsepower = 271, Kilowatts = 202 });
            _cars.Add(new FindCar.Car { Id = 3, Make = "Ford", Model = "Mustang", Year = 2022, Price = 62990.00m, BodyType = "Coupe", Weight = 1725, Horsepower = 460, Kilowatts = 343 });
            _cars.Add(new FindCar.Car { Id = 4, Make = "Chevrolet", Model = "Camaro", Year = 2022, Price = 85990.00m, BodyType = "Coupe", Weight = 1683, Horsepower = 455, Kilowatts = 339 });
            _cars.Add(new FindCar.Car { Id = 5, Make = "Volkswagen", Model = "Golf GTI", Year = 2022, Price = 58490.00m, BodyType = "Hatchback", Weight = 1399, Horsepower = 242, Kilowatts = 180 });
        }
        //this is the formating for the information
        public void PrintCars()
        {
            Console.WriteLine("Car List:\n");
            Console.WriteLine("| ID  | Make        | Model     | Year | Price (AUD) | Body Type   | Weight (kg)  | Horsepower | Kilowatts |");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");

            foreach (var car in _cars)
            {
                // Printing each car's information in a formatted table
                Console.WriteLine($"| {car.Id.ToString().PadRight(3)} | {car.Make?.PadRight(11)} | {car.Model?.PadRight(9)} | {car.Year.ToString().PadRight(4)} | ${car.Price.ToString("F2").PadRight(10)} | {car.BodyType?.PadRight(11)} | {car.Weight.ToString().PadRight(12)} | {car.Horsepower.ToString().PadRight(10)} | {car.Kilowatts.ToString().PadRight(9)} |");
            }
        }
        //this the formating when the search command is run
        public void DisplayCarById(int id)
        {
            var car = _cars.Find(c => c.Id == id); // Finding a car in the list by its ID

            if (car != null)
            {
                Console.WriteLine("Car Details:\n");
                Console.WriteLine("| ID | Make        | Model      | Year | Price (AUD) | Body Type   | Weight (kg) | Horsepower | Kilowatts |");
                // Printing the details of the found car in a formatted table
                Console.WriteLine($"| {car.Id.ToString().PadRight(3)} | {car.Make?.PadRight(11)} | {car.Model?.PadRight(9)} | {car.Year.ToString().PadRight(4)} | ${car.Price.ToString("F2").PadRight(10)} | {car.BodyType?.PadRight(11)} | {car.Weight.ToString().PadRight(12)} | {car.Horsepower.ToString().PadRight(10)} | {car.Kilowatts.ToString().PadRight(9)} |");
            }
            else
            {
                Console.WriteLine("Car not found.");
            }
        }
        //this is how to add a car to the information
        public void AddCar()
        {
            Console.WriteLine("Enter car details:");
            Console.WriteLine("ID:");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Make:");
                string ?make = Console.ReadLine();

                Console.WriteLine("Model:");
                string ?model = Console.ReadLine();

                Console.WriteLine("Year:");
                if (int.TryParse(Console.ReadLine(), out int year))
                {
                    Console.WriteLine("Price (AUD):");
                    if (decimal.TryParse(Console.ReadLine(), out decimal price))
                    {
                        Console.WriteLine("Body Type:");
                        string ?bodyType = Console.ReadLine();

                        Console.WriteLine("Weight (kg):");
                        if (int.TryParse(Console.ReadLine(), out int weight))
                        {
                            Console.WriteLine("Horsepower:");
                            if (int.TryParse(Console.ReadLine(), out int horsepower))
                            {
                                Console.WriteLine("Kilowatts:");
                                if (int.TryParse(Console.ReadLine(), out int kilowatts))
                                {
                                    // Creating a new car object with the entered details
                                    var car = new FindCar.Car
                                    {
                                        Id = id,
                                        Make = make,
                                        Model = model,
                                        Year = year,
                                        Price = price,
                                        BodyType = bodyType,
                                        Weight = weight,
                                        Horsepower = horsepower,
                                        Kilowatts = kilowatts
                                    };

                                    _cars.Add(car); // Adding the new car to the list
                                    Console.WriteLine("Car added successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid kilowatts value.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid horsepower value.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid weight value.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid price value.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid year value.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID.");
            }
        }
        //this is how a car in delete from the information
        public void DeleteCar(int id)
        {
            var car = _cars.Find(c => c.Id == id); // Finding a car in the list by its ID

            if (car != null)
            {
                _cars.Remove(car); // Removing the car from the list
                Console.WriteLine("Car deleted successfully.");
            }
            else
            {
                Console.WriteLine("Car not found.");
            }
        }
        //this is how the cars are sorted
        public void SortMake()
        {
            _cars.Sort((car1, car2) => string.Compare(car1.Make, car2.Make, StringComparison.Ordinal));
        }
    }
}
