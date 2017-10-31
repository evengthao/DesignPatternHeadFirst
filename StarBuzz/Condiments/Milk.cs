using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee.StarBuzz;

namespace StarBuzz.Condiments
{
    class Milk : CondimentDecorator
    {
        private Beverage _beverage;

        public Milk(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string Description
        {
            get { return this._beverage + ", Milk"; } 
        }

        public override double Cost
        {
            get { return .10 + this._beverage.Cost; }
        }
    }
}
