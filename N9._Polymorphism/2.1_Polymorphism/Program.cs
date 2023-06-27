/*Polymorphism*/
public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    //Dynamic dispatch
    public virtual void Speak()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }

    public virtual void Jump()
    {
        Console.WriteLine($"Base animal is jumping");
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    //Method hiding - redefines the method
    public new void Speak()
    {
        Console.WriteLine($"{Name} barks.");
    }

    public override void Jump()
    {
        Console.WriteLine("Derived animal is jumping");
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public new void Speak()
    {
        Console.WriteLine($"{Name} meows.");
    }

    public override void Jump()
    {
        Console.WriteLine("Derived animal is jumping");
    }
}

public class Program
{
    public static void Main()
    {
        Animal myAnimal = new Animal("Generic animal");
        Dog myDog = new Dog("Dog");
        Animal myCat = new Cat("Cat");

        myAnimal.Speak(); // output: generic animal makes a sound
        myDog.Speak(); // output: dog barks
        myCat.Speak(); // output: cat makes a sound - Compile time is an Animale, at runtime is a cat


        myAnimal.Jump();// output: Base animal is jumping
        myDog.Jump(); // output: derived animal is jumping
        myCat.Jump(); //output Derive animal is jumping.

    }
}