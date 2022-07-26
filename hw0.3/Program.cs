namespace TemplateMethod;

// base abstrack classimiz
abstract class Car
{
    // Abstract Methodlarimiz
    public abstract void Model();
    public abstract void Doors();
    public abstract void FuelType();
    // Template Methodumuz virtuala yaziriq diyer subclasslar oz Methodelarini cagira bilsinler 
    public virtual void TemplateMethod()
    {
        Model();
        Doors();
        FuelType();
        Console.WriteLine("____----____----____");
        Console.ForegroundColor = ConsoleColor.White;
    }

}

// sub classimiz
class BMW : Car
{
    public BMW()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
    // override edib oz methodumuzu yaziriq
    public override void Doors()
    {
        Console.WriteLine("4 Door");
    }

    public override void FuelType()
    {
        Console.WriteLine("Fuel Type Benzin");
    }

    public override void Model()
    {
        Console.WriteLine("BMW X7");
    }
}
// sub classimiz
class Tayota : Car
{
    public Tayota()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }
    public override void Doors()
    {
        Console.WriteLine("4 Door");
    }

    public override void FuelType()
    {
        Console.WriteLine("Fuel Type Benzin");
    }

    public override void Model()
    {
        Console.WriteLine("Tayota Karola");
    }
}



class Program
{
    static void Main()
    {
        Car sql = new BMW();
        sql.TemplateMethod();
        /////////////////////////
        sql = new Tayota();
        sql.TemplateMethod();
    }
}