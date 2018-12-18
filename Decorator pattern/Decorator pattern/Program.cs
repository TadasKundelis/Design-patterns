using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            CoffeeWithSugar coffeeWithSugar = new CoffeeWithSugar(coffee); //first decoration
            CoffeeWithMilk coffeeWithSugarAndMilk = new CoffeeWithMilk(coffeeWithSugar); //second decoration

            Console.WriteLine(coffee.GetDescription()); // 'Just simple coffee'
            Console.WriteLine("Cost: " + coffee.GetCost()); // 2
            Console.WriteLine(coffeeWithSugar.GetDescription()); // 'Just simple coffee + sugar'
            Console.WriteLine("Cost: " +  coffeeWithSugar.GetCost()); // 2 + 0.05 = 2.05
            Console.WriteLine(coffeeWithSugarAndMilk.GetDescription()); // 'Just simple coffee + sugar + milk'
            Console.WriteLine("Cost: " + coffeeWithSugarAndMilk.GetCost()); // 2.05 + 0.5 = 2.55
            Console.ReadKey();
        }
    }
}
