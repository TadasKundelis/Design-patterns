using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_pattern
{
    public abstract class Vehicle
    {
        public abstract string Color { get; set; }
        public abstract string Price { get; set; }
        public abstract string Type { get; }
    }
}
