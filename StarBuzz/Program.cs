using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee.StarBuzz;
using StarBuzz.Coffee;
using StarBuzz.Condiments;

namespace StarBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Expresso();

            Console.WriteLine(beverage.Description + " $" + beverage.Cost);

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description + " $" + beverage2.Cost);

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.Description + " $" + beverage3.Cost);

            Console.ReadKey();
        }
    }
}
