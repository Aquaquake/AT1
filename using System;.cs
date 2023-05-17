using System;



class text
{
    public void CarData(string ID, string Make, string Model, int Year, decimal price, string BodyType, string Engine, int Weight)
    {
        result.Query = "Update tbl_student set lastname = '" + lastname + "', firstname = '" + firstname + "', middlename = '" + middlename + "', suffix = '" + suffix + "', age = '" + age + "', gender = '" + gender + "', pmt_address = '" + paddress + "', birthday = to_date('" + String.Format("{0:MM/dd/yyyy}", birthday.ToShortDateString()) + "','mm/dd/yyyy') where std_id = '" + id + "'";
        result.Transaction = true;
        result.ExecuteNonQuery();
        CarCommit();
        result.Close();
    }

    public void CarDelete(string id)
    {
        result.Query = "Delete from tbl_student where std_id = '" + id + "'";
        result.ExecuteNonQuery();
        CarCommit();
       result.Close();
    }

    public void CarCommit()
    {
        if (!result.Commit())
        {
        result.Rollback();
    }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Engine fourCylinder = new Engine("4-cylinder", 0, 0);
        Engine v8 = new Engine("V8", 0, 0);
        //table for the data of cars 
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
