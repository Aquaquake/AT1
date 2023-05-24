void menu01_disp()
{
    Console.WriteLine("Inventory");
    Console.WriteLine("1. Find stock item.");
    Console.WriteLine("2. Add stock item.");
    Console.WriteLine("3. Delete stock item.");
    Console.WriteLine("4. Quit");
}
void menu01_stock_find()
{
    Console.WriteLine("Finding stock\n");
}
void menu01_stock_add()
{
    Console.WriteLine("Adding stock\n");
}
void menu01_stock_del()
{
    Console.WriteLine("Deleting stock\n");
}
void menu01()
{
    for (;;)
    {
        menu01_disp();
        string s = Console.ReadLine();
        if (s=="1")
        {
            menu01_stock_find();
            continue;
        }
        // TODO - other cases
        if (s=="4")
        break;
    }
}