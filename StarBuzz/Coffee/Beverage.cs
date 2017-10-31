using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.StarBuzz
{
    public class Beverage
    {
        public virtual string Description { get; protected set; }
        public virtual double Cost { get; protected set; }
    }
}
