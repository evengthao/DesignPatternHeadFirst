using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class CheesePizza : Pizza
    {
        public CheesePizza() : base("Cheese Pizza", "Regular Crust", "Marinara Pizza Sauce")
        {
                Toppings.Add("Fresh Mozzarella");
                Toppings.Add("Parmesan");
        }
    }
}
