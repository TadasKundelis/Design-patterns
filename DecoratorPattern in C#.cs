using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Coffee interface
public interface ICoffee
{
    string GetDescription();
    double GetCost();
}

//Concrete Coffee class
public class Coffee: ICoffee
{
    public string GetDescription() {
        return "Just simple coffee";
    }
    public double GetCost() {
        return 2;
    }

}

//Abstract Decorator class
public abstract class CoffeeDecorator: ICoffee
{
    private ICoffee _coffee;
    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription(); 
    }

    public virtual double GetCost()
    {
        return _coffee.GetCost();
    }
}

//Concrete Decorator classes
public class CoffeeWithSugar: CoffeeDecorator
{
    public CoffeeWithSugar(ICoffee coffee) 
    : base(coffee){ }

    public override string GetDescription()
    {
        return base.GetDescription() + " + sugar";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.05;
    }
}

public class CoffeeWithMilk : CoffeeDecorator
{
    public CoffeeWithMilk(ICoffee coffee)
    : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + " + milk";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }

}

//Example output
static void Main(string[] args)
{
    Coffee coffee = new Coffee();
    CoffeeWithSugar coffeeWithSugar = new CoffeeWithSugar(coffee); //first decoration
    CoffeeWithMilk coffeeWithSugarAndMilk = new CoffeeWithMilk(coffeeWithSugar); //second decoration

    Console.WriteLine(coffee.GetDescription()); // 'Just simple coffee'
    Console.WriteLine(coffee.GetCost()); // 2
    Console.WriteLine(coffeeWithSugar.GetDescription()); // 'Just simple coffee + sugar'
    Console.WriteLine(coffeeWithSugar.GetCost()); // 2 + 0.05 = 2.05
    Console.WriteLine(coffeeWithSugarAndMilk.GetDescription()); // 'Just simple coffee + sugar + milk'
    Console.WriteLine(coffeeWithSugarAndMilk.GetCost()); // 2.05 + 0.5 = 2.55
    Console.ReadKey();
}



