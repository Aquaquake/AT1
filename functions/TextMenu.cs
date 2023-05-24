namespace AT1.Models;

public class TextMenu
{
    private ListOfCars _carModel;
    
    public TextMenu()
    {
        _carModel = new ListOfCars();
        _carModel.InsertData();
    }

    public void DisplayMenu()
    {
       Console.WriteLine("Car Data.");
       Console.WriteLine("1.Display Car");
       Console.WriteLine("2. Find Car.");
       Console.WriteLine("3. Add Car.");
       Console.WriteLine("4. Delete Car.");
       Console.WriteLine("5. Quit");



      var UserInput = Console.ReadLine();

       switch(UserInput) 
       {
        case "1":
            menu01_display_car();
            DisplayMenu();
            break;
        case "2": 

            break;
        case "3":
            break;
        case "4":
            break;
        case "5":

            break;


       }
    }

    private void menu01_display_car()
    {
        _carModel.PrintCars();
    }
    void menu01_find_car()
    {
        Console.WriteLine("Find Car\n");
    }
    void menu01_add_car()
    {
       Console.WriteLine("Add Car\n");
    }
    void menu01_del_car()
    {
       Console.WriteLine("Delete Car\n");
    }
    /*
    void menu01()
    {
      for (;;)
      {
           menu01_disp();
          string s = Console.ReadLine();
           if (s=="1")
           {
                menu01_find_car();
                continue;
            }
            // TODO - other cases
            if (s=="5")
            break;
        }

        */
    }
