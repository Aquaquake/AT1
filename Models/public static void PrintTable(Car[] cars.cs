public static void PrintTable(Car[] cars)
    {
        // Calculate column widths
        int makeWidth = GetMaxWidth(cars, car => car.Make.Length);
        int modelWidth = GetMaxWidth(cars, car => car.Model.Length);
        int yearWidth = GetMaxWidth(cars, car => car.Year.ToString().Length);
        int priceWidth = GetMaxWidth(cars, car => car.Price.ToString("C").Length);
        int bodyTypeWidth = GetMaxWidth(cars, car => car.BodyType.Length);
        int horsepowerWidth = GetMaxWidth(cars, car => car.Horsepower.ToString().Length);
        int weightWidth = GetMaxWidth(cars, car => car.Weight.ToString().Length);

        // Print table headers
        Console.WriteLine("{0,-" + makeWidth + "} {1,-" + modelWidth + "} {2,-" + yearWidth + "} {3,-" + priceWidth + "} {4,-" + bodyTypeWidth + "} {5,-" + horsepowerWidth + "} {6,-" + weightWidth + "}",
            "Make", "Model", "Year", "Price", "Body Type", "Horsepower", "Weight");

        // Print table rows
        foreach (Car car in cars)
        {
            Console.WriteLine("{0,-" + makeWidth + "} {1,-" + modelWidth + "} {2,-" + yearWidth + "} {3,-" + priceWidth + "} {4,-" + bodyTypeWidth + "} {5,-" + horsepowerWidth)
        }
        
    }