/*Interface*/
public interface IGreeter
{
    void Greet(string name);
}

public class ConsoleGreeter : IGreeter
{
    public void Greet(string name)
    {
        Console.WriteLine($"Hello {name}");
    }
}

/*Implemente more interfaces*/
public interface IFly
{
    void Move();
}

public interface IDrive
{
    void Move();
}

public class FlyingCar : IFly, IDrive
{
    void IFly.Move()
    {
        Console.WriteLine("The flying car is flying.");
    }

    void IDrive.Move()
    {
        Console.WriteLine("The flying car is driving.");
    }
}

public class Program
{
    public static void Main()
    {
        ConsoleGreeter greeter1 = new();
        greeter1.Greet("Andrea");

        IGreeter greeter2 = new ConsoleGreeter();
        greeter2.Greet("Andrea");

        FlyingCar car = new FlyingCar();

        // The following lines would result in a compile-time error
        // car.Move();

        // Access the methods through the interfaces
        IFly flyInterface = car;
        flyInterface.Move(); // Output: The flying car is flying.

        IDrive driveInterface = car;
        driveInterface.Move(); // Output: The flying car is driving.
    }
}