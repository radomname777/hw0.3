namespace Strategy;
interface Icar
{
    void Car();
}



class Bmw : Icar
{
    public void Car()
    {
        Console.WriteLine("BMW X7");
    }
}

class Land_Rover : Icar
{
    public void Car()
    {
        Console.WriteLine("Land Rover Discovery");
    }
}

class Ford : Icar
{
    public void Car()
    {
        Console.WriteLine("Ford Mustang");
    }
}

class Gallery
{
    private readonly Icar _car;

    public Gallery(Icar serializer)
    {
        _car = serializer;
    }

    public void Car()
    {
        _car.Car();
    }
}



class Program
{
    static void Main()
    {
        Gallery _context = new Gallery(new Land_Rover());
        _context.Car();
    }
}