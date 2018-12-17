using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    interface IPizza
    {
        Size Size { get; set; }
        Cheese Cheese { get; set; }
        bool Ham { get; set; }
        bool Olives { get; set; }
        bool Mushrooms { get; set; }
    }
    class Pizza : IPizza
    {
        public Size Size { get; set; }
        public Cheese Cheese { get; set; }
        public bool Ham { get; set; }
        public bool Olives { get; set; }
        public bool Mushrooms { get; set; }
        public Pizza(
            Size size = Size.Medium, 
            Cheese cheese = Cheese.None,
            bool ham = false,
            bool olives = false,
            bool mushrooms = false)
        {
            Size = size;
            Cheese = cheese;
            Ham = ham;
            Olives = olives;
            Mushrooms = mushrooms;
        }
    }
}
