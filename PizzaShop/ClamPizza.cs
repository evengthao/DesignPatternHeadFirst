using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class ClamPizza : Pizza
    {
        public ClamPizza() : base("Clam Pizza", "Thin crust", "White garlic sauce")
        {
            Toppings.Add("Clams");
            Toppings.Add("Grated parmesan cheese");
        }
    }
}
