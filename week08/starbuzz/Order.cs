using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    internal class Order
    {
        public Beverage beverage { get; set; }  
        public Size size { get; set; }
        public List<Topping> toppings { get; set; }

        public Order() 
        {
            beverage = null;
            toppings = new List<Topping>();
        }

        public void CreateOrder(List<Beverage> beverages, List<Topping> toppings) 
        {
            SelectBeverage(beverages);
            SelectToppings(toppings);
        }

        public void SelectBeverage(List<Beverage> beverages) 
        {
            int counter = 1;
            foreach(Beverage beverage in beverages) 
            {
                Console.WriteLine(counter + ". " + beverage.Name);
                counter++;
            }
            Console.Write("Select: ");
            int selection = Int32.Parse(Console.ReadLine());
            // Check for valid selection (1 to counter)
            beverage = beverages[selection - 1];

            counter = 1;
            foreach(Size size in beverage.Sizes) 
            { 
                Console.WriteLine(counter + ". " + size.Name);
                counter++;
            }
            Console.Write("Select Size: ");
            selection = Int32.Parse(Console.ReadLine());
            // Check for error
            size = beverage.Sizes[selection - 1];
        }

        public void SelectToppings(List<Topping> toppings)
        {
            int selection = 0;
            int counter = 1;
            do
            {
                Console.WriteLine("Toppings");
                counter = 1;
                foreach(Topping topping in toppings)
                {
                    Console.WriteLine(counter + ". " + topping.Name);
                    counter++;
                }
                Console.WriteLine("0. None");
                Console.Write("Select: ");
                selection = Int32.Parse(Console.ReadLine());
                // Check for error
                if (selection != 0)
                {
                    this.toppings.Add(toppings[selection - 1]);
                }

            } while (selection != 0);
        }

        public double GetPrice()
        {
            double price = 0;

            price = size.Price;
            foreach(Topping topping in toppings)
            {
                price += topping.Price;
            }

            return price;
        }

        public override string ToString()
        {
            string str = beverage.Name;
            foreach(Topping topping in toppings)
            {
                str += " " + topping.Name;
            }
            str +=", price: " + GetPrice();

            return str;
        }
    }
}
