using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class SimplePizzaFactory
    {

        public Pizza CreatePizza(string type)
        {
            Dictionary<string, Pizza> dictionary = new Dictionary<string, Pizza>();
            dictionary.Add("cheese",new CheesePizza());
            dictionary.Add("pepperoni", new PepperoniPizza());
            dictionary.Add("clam", new ClamPizza());
            dictionary.Add("veggie", new VeggiePizza());

            return dictionary[type];
        }
    }
}
