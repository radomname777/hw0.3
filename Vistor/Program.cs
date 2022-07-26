namespace Visitor;

// base classimiz
interface ICan
{
    void Accept(ILaptopVisitor visitor);
}

// Concret classimiz 

class Notebook : ICan
{
    public string Model { get; set; }

    public Notebook(string model)
    {
        Model = model;
    }

    public void Accept(ILaptopVisitor visitor)
        => visitor.Visit(this);
}
// sub class larimiz
class Asus : Notebook
{
    public Asus() : base("Asus Tuf Gameing") { }
}

class Dell : Notebook
{
    public Dell() : base("Dell G15 5511") { }
}

class Apple : Notebook
{
    public Apple() : base("Apple MacBook PRO 16") { }
}


// base visotrumuz
interface ILaptopVisitor
{
    void Visit(Notebook mobilePhone);
}
// toreme vistorlar
class GameVisitor : ILaptopVisitor
{
    public void Visit(Notebook mobilePhone)
    {
        Console.WriteLine($"{mobilePhone.Model} playing gta 5");
    }
}

class MacBookVisitor : ILaptopVisitor
{
    public void Visit(Notebook mobilePhone)
    {
        Console.WriteLine($"{mobilePhone.Model} an apple product");
    }
}

class office_And_Business_Vistor : ILaptopVisitor
{
    public void Visit(Notebook mobilePhone)
    {
        Console.WriteLine($"{mobilePhone.Model} Suitable for microsoft office and business meeting");
    }
}



class Program
{
    static void Main()
    {
        GameVisitor Gamer = new();
        MacBookVisitor Mac = new();
        office_And_Business_Vistor Work = new();


        Apple Macbook = new();
        Macbook.Accept(Mac);
        Macbook.Accept(Work);
        Console.WriteLine("------------------");


        Asus asus = new();
        asus.Accept(Gamer);
        Console.WriteLine("------------------");


        Dell G15 = new();
        G15.Accept(Work);
        G15.Accept(Gamer);
        Console.WriteLine("------------------");

    }

}
