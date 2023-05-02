// Load Data
using rent_a_car;

CarRental rentals = new CarRental();
int choice = 0;

do
{
    try
    {
        Console.WriteLine("1. Display Cars");
        Console.WriteLine("2. Display Customers");
        Console.WriteLine("0. EXIT");
        Console.Write("> ");
        choice = Int32.Parse(Console.ReadLine());

        if (choice == 1)
        {
            rentals.PrintCars()
        }
        if(choice == 2)
        {
            rentals.PrintCustomers();
        }
    }
    catch(FormatException ex)
    {
        Console.WriteLine("ERROR: Numbers only please");
        choice = -1;
    }

} while (choice != 0);