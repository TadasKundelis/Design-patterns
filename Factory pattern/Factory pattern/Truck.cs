using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_pattern
{
    public class Truck : Vehicle
    {
        private string _color;
        private string _price;
        private readonly string _type;

        public Truck(string Color, string Price)
        {
            _color = Color;
            _price = Price;
            _type = "Truck";
        }

        public override string Color 
        {
            get { return _color; }
            set { _color = value; }
        }

        public override string Price 
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string Type 
        {
            get { return _type; }
        }
    }
}
