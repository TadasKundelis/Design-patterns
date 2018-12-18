using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    //Coffee interface
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }

    //Concrete Coffee class
    public class Coffee : ICoffee
    {
        public string GetDescription()
        {
            return "Just simple coffee";
        }
        public double GetCost()
        {
            return 2;
        }

    }
}
