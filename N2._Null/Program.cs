public class Program
{
    public class Person
    {
        public String Name { get; set; }
    }
    public static void Main()
    {
        /*Null handling*/
        Person person1 = new Person { Name = "Alice" };
        Person person2 = null;

        // If statement
        if (person1 != null)
        {
            Console.WriteLine("Person1 is not null");
        }
        else
        {
            Console.WriteLine("Person1 is null");
        }

        // Null-conditional operator
        string name2 = person2?.Name;
        Console.WriteLine($"Name2: {name2}"); // Output: "Name2: "

        // Null coalescing operator
        string name3 = person2?.Name ?? "Unknown";
        Console.WriteLine($"Name3: {name3}"); // Output: "Name3: Unknown"

        // Null coalescing assignment operator (C# 8.0 and later)
        person2 ??= new Person { Name = "Bob" };
        Console.WriteLine($"person2.Name: {person2.Name}"); // Output: "person2.Name: Bob"

        //Nullable value type
        int? nullableInt = null;
        Console.WriteLine(nullableInt);
    }
}