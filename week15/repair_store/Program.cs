
using repairstore;

int choice = 0;
Store store = new Store();

do
{
    // Display Menu
    Console.WriteLine("\nMENU");
    Console.WriteLine("1. Customers");
    Console.WriteLine("2. Clerks");
    Console.WriteLine("3. Engineers");
    Console.WriteLine("4. Add Repair");
    Console.WriteLine("5. Repairs");
    Console.WriteLine("6. Open Repairs");
    Console.WriteLine("7. Assign Engineer");
    Console.WriteLine("8. Close Repair");
    Console.WriteLine("0. EXIT");

    // Ask user for choice
    Console.Write("Choose: ");
    choice = Int32.Parse(Console.ReadLine());

    // Respond to choice
    if(choice == 1)
    {
        store.PrintCustomers();
    }
    else if (choice == 2)
    {
        store.PrintClerks();
    }
    else if (choice == 3)
    {
        store.PrintEngineers();
    }
    else if (choice == 4)
    {
        store.AddRepair();
    }
    else if (choice == 5)
    {
        store.PrintRepairs();
    }
    else if (choice == 6)
    {
        store.PrintOpenRepairs();
    }
    else if (choice == 7)
    {
        store.AddEngineer();
    }
    else if (choice == 8)
    {
        store.CloseRepair();
    }
    else if(choice == 0)
    {
        Console.WriteLine("Bye!");
    }


} while (choice != 0);

