using System;
using AT1.Models;
using AT1;

class Program
{
    static void Main(string[] args)
    {
        TextMenu textMenu = new TextMenu();
        while (true) 
        {
            textMenu.DisplayMenu();
        }
    }
}
