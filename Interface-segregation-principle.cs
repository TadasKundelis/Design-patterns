//Main rule: no client code object should be forced to depend on methods it does not use

//Let's say we have an IProduct interface used for clothing products

public interface IProduct
{
    int ID { get; set; }
    double Weight { get; set; }
    int Stock { get; set; }
    int Inseam { get; set; }
    int WaistSize { get; set; }
}

//and a concrete class implementing it
public class Jeans : IProduct
{
    public int ID { get; set; }
    public double Weight { get; set; }
    public int Stock { get; set; }
    public int Inseam { get; set; }
    public int WaistSize { get; set; }
}

//then we decide to have a different type of product, a baseballcap

public class BaseballCap : IProduct
{
    public int ID { get; set; }
    public double Weight { get; set; }
    public int Stock { get; set; }
    public int Inseam { get; set; }
    public int WaistSize { get; set; }
    public int HatSize { get; set; }
}

//The problem is that baseballcap does not need waistsize or inseam and should not be implementing these properties.
// Apparently IProduct interface is too general and we'll need to create three separate interfaces: IProduct, IPants, IHat:

public interface IProduct
{
    int ID { get; set; }
    double Weight { get; set; }
    int Stock { get; set; }
}

public interface IPants
{
    public int Inseam { get; set; }
    public int WaistSize { get; set; }
}

public interface IHat
{
    public int HatSize { get; set; }
}

//Now Jeans and BaseballCap implement only the properties they need. 

public class Jeans : IProduct, IPants
{
    public int ID { get; set; }
    public double Weight { get; set; }
    public int Stock { get; set; }
    public int Inseam { get; set; }
    public int WaistSize { get; set; }
}

public class BaseballCap : IProduct, IHat
{
    public int ID { get; set; }
    public double Weight { get; set; }
    public int Stock { get; set; }
    public int HatSize { get; set; }
}

