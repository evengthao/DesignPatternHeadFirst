using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class PizzaStore
    {
        private SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this._factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = _factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
