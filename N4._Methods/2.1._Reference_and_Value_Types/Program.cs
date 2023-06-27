public class Program
{
    public class Person
    { // reference object - stored in the heap
        public string Name;
    };

    public static void Main()
    {
        /*Value Types and Reference Types*/
        //Value types
        int a = 10;
        int b = a;

        a = 20;

        Console.WriteLine(a); // Output: 20
        Console.WriteLine(b); // Output: 10 

        //Reference type
        var person1 = new Person() { Name = "Andrea" };
        Person person2 = person1;

        Console.WriteLine(person1.Name); // Output: Andrea
        Console.WriteLine(person2.Name); // Output: Andrea

        person2.Name = "New Name";

        Console.WriteLine(person1.Name); // Output: New Name
        Console.WriteLine(person2.Name); // Output: New Name
    }
}