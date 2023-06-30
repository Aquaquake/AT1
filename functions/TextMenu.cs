using System;
using System.Collections.Generic;

namespace AT1.Models
{
    public class TextMenu
    {
        private ListOfCars _carModel;
        private ListOfCars _cars;
        //
        public TextMenu()
        {
            _carModel = new ListOfCars();
            _carModel.InsertData(); // Inserting initial car data
            _cars = new ListOfCars();
        }
        //display menu to the console 
        public void DisplayMenu()
        {
            Console.WriteLine("Car Data.");
            Console.WriteLine("1. Display Cars");
            Console.WriteLine("2. Find Car");
            Console.WriteLine("3. Add Car");
            Console.WriteLine("4. Delete Car");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. search");

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
                case "6":
                    menu06_search(); // Sorting and displaying cars by make
                    DisplayMenu();
                    break;
            }
        }
        //print the menu to the console
        private void Menu01_DisplayCars()
        {
            _carModel.PrintCars(); // Printing the list of cars
        }
        //this uses the ID to locate the car in the information
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
        //this add the car to the informations 
        private void Menu03_AddCar()
        {
            _carModel.AddCar(); // Adding a new car to the list
        }
        //this deletes a car from the information
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
        //this search the information for a car
        private void menu06_search()
        {
            _carModel.SortMake(); // Sorting cars by make
            _carModel.PrintCars(); // Printing the sorted list of cars
        }   
    }
}
