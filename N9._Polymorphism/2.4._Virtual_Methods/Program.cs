// Base class
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal speaks.");
    }
}

// Derived class
public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class Program
{
    public static void Main()
    {
        // Usage
        Animal myAnimal = new Dog();
        myAnimal.Speak(); // Output: The dog barks.
    }
}