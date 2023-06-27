/*Inheritance*/
public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void Speak()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} barks.");
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} meows.");
    }
}

public class Program
{
    public static void Main()
    {
        Animal myAnimal = new Animal("Generic animal");
        Dog myDog = new Dog("Dog");
        Cat myCat = new Cat("Cat");

        myAnimal.Speak(); // Output: Generic Animal Makes a sound
        myDog.Speak(); // Output: Dog barks
        myCat.Speak();// Output: Cat meows

        Animal anotherDog = new Dog("Another Dog");
        anotherDog.Speak(); //Another dogs barks.
    }
}