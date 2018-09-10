using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_pattern
{
    class Car : Vehicle
    {
        private string _color;
        private string _price;
        private readonly string _type;

        public Car(string Color, string Price)
        {
            _color = Color;
            _price = Price;
            _type = "Car";
        }

        public override string Color {
            get { return _color; }
            set { _color = value; }
        }

        public override string Price {
            get { return _price; }
            set { _price = value; }
        }

        public override string Type {
            get { return _type; }
        }
    }
}
