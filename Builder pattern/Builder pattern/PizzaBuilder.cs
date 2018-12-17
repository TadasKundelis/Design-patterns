using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    public enum Cheese { Mozarella, Cheddar, Parmezzano, None }
    public enum Size { Small, Medium, Large, XLarge }
    class PizzaBuilder : IPizza
    {
        public Size Size { get; set; } = Size.Medium;
        public Cheese Cheese { get; set; } = Cheese.None;
        public bool Ham { get; set; }
        public bool Olives { get; set; }
        public bool Mushrooms { get; set; }

        public PizzaBuilder setSize(Size size)
        {
            Size = size;
            return this;
        }
        public PizzaBuilder AddCheese(Cheese cheese)
        {
            Cheese = cheese;
            return this;
        }
        public PizzaBuilder AddHam(bool ham)
        {
            Ham = ham;
            return this;
        }
        public PizzaBuilder AddOlives(bool olives)
        {
            Olives = olives;
            return this;
        }
        public PizzaBuilder AddMushrooms(bool mushrooms)
        {
            Mushrooms = mushrooms;
            return this;
        }
        public Pizza Build()
        {
            return new Pizza(
                size: Size,
                cheese: Cheese,
                ham: Ham,
                olives: Olives,
                mushrooms: Mushrooms
            );
        }
    }
}

