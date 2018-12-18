using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class CoffeeWithMilk : CoffeeDecorator
    {
        public CoffeeWithMilk(ICoffee coffee)
        : base(coffee) { }

        public override string GetDescription()
        {
            return base.GetDescription() + " + milk";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }

    }
}
