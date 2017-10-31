using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee.StarBuzz;

namespace StarBuzz.Condiments
{
    class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string Description
        {
            get { return this._beverage.Description + ", Whip"; }
        }

        public override double Cost
        {
            get { return this._beverage.Cost + .10; }
        }
    }
}
