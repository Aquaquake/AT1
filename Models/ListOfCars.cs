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
        Cars.Add(new CarModel(1, "Mazda", "MX-5", 2022, 41960M, "Convertible", 5, 432));
        Cars.Add(new CarModel(2, "Subaru", "WRX", 2022, 43490M, "Sedan", 45, 123));
        Cars.Add(new CarModel(3, "Ford", "Mustang", 2022, 62990M, "Coupe", 6, 654));
        Cars.Add(new CarModel(4, "Chevrolet", "Camaro", 2022, 85990M, "Coupe", 234, 234));
        Cars.Add(new CarModel(5, "Volkswagen", "Golf GTI", 2022, 58490M, "Hatchback", 786, 4523));
    }

    public void OrderByName()
    {
        Cars = Cars.OrderBy(c => c.Make).ToList();
    }

    public void SortByBodyType() 
    {
        Cars = Cars.OrderBy(c => c.BodyType).ToList();
    }
}