using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SimplePizzaFactory();
            var store = new PizzaStore(factory);

            var pizza = store.OrderPizza("cheese");
            Console.WriteLine("We ordered a " + pizza.Name + "\n");

            pizza = store.OrderPizza("veggie");
            Console.WriteLine("We ordered a " + pizza.Name + "\n");

            Console.ReadKey();
        }
    }
}
