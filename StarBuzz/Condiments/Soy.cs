using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee.StarBuzz;

namespace StarBuzz.Condiments
{
    class Soy : CondimentDecorator
    {
        private Beverage _beverage;

        public Soy(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string Description
        {
            get { return this._beverage.Description + ", Soy"; }
        }

        public override double Cost
        {
            get { return  .15 + this._beverage.Cost; }
        }
    }
}
