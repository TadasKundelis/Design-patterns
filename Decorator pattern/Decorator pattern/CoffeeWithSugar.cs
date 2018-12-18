using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class CoffeeWithSugar : CoffeeDecorator
    {
        public CoffeeWithSugar(ICoffee coffee)
        : base(coffee) { }

        public override string GetDescription()
        {
            return base.GetDescription() + " + sugar";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.05;
        }
    }
}
