using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza() : base("Pepperoni Pizza", "Crust", "Marinara sauce")
        {
            Toppings.Add("Sliced Pepperoni");
            Toppings.Add("Sliced Onion");
            Toppings.Add("Grated parmesan cheese");
        }
    }
}
