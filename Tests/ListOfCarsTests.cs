using NUnit.Framework;
using AT1.Models;

namespace AT1.Tests
{
    [TestFixture]
    public class ListOfCarsTests
    {
        private ListOfCars? _carList;

        [SetUp]
        public void Setup()
        {
            _carList = new ListOfCars();
            _carList.InsertData(); // Inserting initial car data for testing
        }

        [Test]
        public void PrintCars_ShouldPrintListOfCars()
        {
            // Arrange (already done in the Setup method)

            // Act
            _carList?.PrintCars();

            // Assert
            // Verify the expected output manually
        }

        [Test]
        public void DisplayCarById_ExistingId_ShouldDisplayCarDetails()
        {
            // Arrange
            int carId = 3; // Assuming a car with ID 3 exists in the initial data

            // Act
            _carList?.DisplayCarById(carId);

            // Assert
            // Verify the expected output manually
        }

        [Test]
        public void DisplayCarById_NonExistingId_ShouldDisplayNotFoundMessage()
        {
            // Arrange
            int carId = 10; // Assuming there is no car with ID 10 in the initial data

            // Act
            _carList?.DisplayCarById(carId);

            // Assert
            // Verify the expected output manually
        }

        // Additional test cases for other methods can be added in a similar manner
    }
}
