
using StarBuzz;

List<Beverage> beverages= new List<Beverage>();
List<Topping> toppings= new List<Topping>();
List<Order> orders= new List<Order>();

beverages.Add(new Espresso());
beverages.Add(new Latte());
toppings.Add(new Cinammon());
toppings.Add(new Cream());

int choice;
do
{
    Console.WriteLine("1. Order");
    Console.WriteLine("2. History");
    Console.WriteLine("0. EXIT");
    choice = Int32.Parse(Console.ReadLine());
    switch(choice)
    {
        case 1:
            Order order = new Order();
            order.CreateOrder(beverages, toppings);
            Console.WriteLine("Price: " + order.GetPrice());
            orders.Add(order);
            break;
        case 2:
            foreach(Order ord in orders)
            {
                Console.WriteLine(ord);
            }
            break;
        case 0:
            Console.WriteLine("Bye!");
            break;
    }
} while (choice != 0);
