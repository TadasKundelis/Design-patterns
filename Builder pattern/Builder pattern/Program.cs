using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder pizzaBuilder = new PizzaBuilder();
            //create pizza with Cheddar, Ham and Olives and default size, Medium
            pizzaBuilder
                .AddCheese(Cheese.Cheddar)
                .AddHam(true)
                .AddOlives(true);
            
            //bake the pizza
            Pizza pizzaWithCheddar = pizzaBuilder.Build();

            //the same builder instance can be reused and modified: lets add Mozzarella, set size to XLarge and remove Ham
            pizzaBuilder
                .AddCheese(Cheese.Mozarella)
                .AddHam(false)
                .setSize(Size.XLarge);

            //bake a difference pizza
            Pizza pizzaWithMozzarella = pizzaBuilder.Build();

            Console.WriteLine(pizzaWithCheddar.Cheese); //Cheddar
            Console.WriteLine(pizzaWithCheddar.Ham); //True
            Console.WriteLine(pizzaWithCheddar.Size); //Medium
            Console.WriteLine("...........................");
            Console.WriteLine(pizzaWithMozzarella.Cheese); //Mozzarella
            Console.WriteLine(pizzaWithMozzarella.Ham); //False
            Console.WriteLine(pizzaWithMozzarella.Size); //XLarge
            Console.WriteLine("...........................");

            //builder class can endlessly modify the inner pizza instance before it is created: 
            pizzaBuilder
                .setSize(Size.Small)
                .AddCheese(Cheese.Parmezzano)
                .AddMushrooms(true)
                .AddHam(true);

            //let's say that we don't want ham anymore:
            pizzaBuilder
                .AddHam(false);

            Pizza pizzaWithMushrooms = pizzaBuilder.Build();
            Console.WriteLine(pizzaWithMushrooms.Cheese); //Parmezzano
            Console.WriteLine(pizzaWithMushrooms.Ham); //False
            Console.WriteLine(pizzaWithMushrooms.Size); //Small
            Console.WriteLine(pizzaWithMushrooms.Mushrooms); //True
            Console.ReadKey();
        }
    }
}
