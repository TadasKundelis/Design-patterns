
//Two simple interfaces
public interface IHaveWings
{
    bool HasWings();
}

public interface IFly
{
    void Fly();
}


//Base Class implements both interfaces
public class Duck : IFly, IHaveWings
{
    public virtual bool HasWings()
    {
        return true;
    }
    
    public virtual void Fly()
    {
        Console.WriteLine("I am real duck and I am flying!");
    }
}
//RubberDuck class inherits from Duck class
public class RubberDuck : Duck
{
    public override bool HasWings()
    {
        return true;
    }

    public override void Fly()
    {
        throw new Exception("Rubber ducks cannot fly!");
    }
}

/*

Now, if we have the following code: 

List<Duck> DuckList = new List<Duck>();
DuckList.Add(new Duck());
DuckList.Add(new RubberDuck());

foreach (Duck duck in DuckList)
{
    duck.Fly();
}

the second item in the list, of type RubberDuck, will throw an Exception.
The problem is that RubberDuck class should not be inheriting from Duck, because RubberDuck is not a Duck.
LISKOV principle says the parent should easily replace the child object.
Let's make RubberDuck only implement IHaveWings interface: 

*/

public class RubberDuck : IHaveWings
{
    public bool HasWings()
    {
        return true;
    }
}


/* 

Now if we have a generic list of type Duck and we try to add items of type RubberDuck, 
IDE won't let us do that, because RubberDuck is not of type Duck.

*/




