using System;
using System.Collections.Generic;

namespace AT1.Models
{
    public class TextMenu
    {
        private ListOfCars _carModel;

        public TextMenu()
        {
            _carModel = new ListOfCars();
            _carModel.InsertData(); // Inserting initial car data
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Car Data.");
            Console.WriteLine("1. Display Cars");
            Console.WriteLine("2. Find Car");
            Console.WriteLine("3. Add Car");
            Console.WriteLine("4. Delete Car");
            Console.WriteLine("5. Quit");

            var userInput = Console.ReadLine(); // Reading user input

            switch (userInput)
            {
                case "1":
                    Menu01_DisplayCars(); // Displaying the list of cars
                    DisplayMenu(); // Displaying the menu again after an operation is performed
                    break;
                case "2":
                    Menu02_FindCar(); // Finding and displaying a specific car
                    DisplayMenu();
                    break;
                case "3":
                    Menu03_AddCar(); // Adding a new car to the list
                    DisplayMenu();
                    break;
                case "4":
                    Menu04_DeleteCar(); // Deleting a car from the list
                    DisplayMenu();
                    break;
                case "5":
                    Environment.Exit(0); // Exiting the program
                    break;
            }
        }

        private void Menu01_DisplayCars()
        {
            _carModel.PrintCars(); // Printing the list of cars
        }

        private void Menu02_FindCar()
        {
            Console.WriteLine("Enter the car ID:");
            if (int.TryParse(Console.ReadLine(), out int carId))
            {
                _carModel.DisplayCarById(carId); // Finding and displaying a car by its ID
            }
            else
            {
                Console.WriteLine("Invalid car ID.");
            }
        }

        private void Menu03_AddCar()
        {
            _carModel.AddCar(); // Adding a new car to the list
        }

        private void Menu04_DeleteCar()
        {
            Console.WriteLine("Enter the car ID:");
            if (int.TryParse(Console.ReadLine(), out int carId))
            {
                _carModel.DeleteCar(carId); // Deleting a car from the list by its ID
            }
            else
            {
                Console.WriteLine("Invalid car ID.");
            }
        }
    }
}