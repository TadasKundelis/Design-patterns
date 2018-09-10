using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_pattern
{
    public class CarFactory : VehicleFactory
    {
        private string _color;
        private string _price;
        public CarFactory(string Color, string Price)
        {
            _color = Color;
            _price = Price;
        }

        public override Vehicle CreateVehicle()
        {
            return new Car(_color, _price);
        }
    }
}
