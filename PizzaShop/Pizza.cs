using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class Pizza
    {
        public Pizza(string name, string dough, string sauce)
        {
            this.Name = name;
            this.Dough = dough;
            this.Sauce = sauce;
        }

        public string Sauce { get; set; }

        public string Dough { get; set; }

        public string Name { get; set; }

        public List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
        }

        public void Bake()
        {
            Console.WriteLine("Baking " + Name);
        }

        public void Cut()
        {
            Console.WriteLine("Cutting " + Name);
        }

        public void Box()
        {
            Console.WriteLine("Boxing " + Name);
        }

        // code to display pizza name and ingredients
        public override string ToString()
        {
            StringBuilder display = new StringBuilder();
            display.Append("---- " + Name + " ----\n");
            display.Append(Dough + "\n");
            display.Append(Sauce + "\n");
            foreach (string topping in Toppings)
            {
                display.Append(topping + "\n");
            }

            return display.ToString();
        }
    }
}
