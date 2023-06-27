//File1.cs
public partial class MyClass
{
    public void Method1()
    {
        Console.WriteLine("Method1");
    }
}

//File2.cs
public partial class MyClass
{
    public void Method2()
    {
        Console.WriteLine("Method2");
    }
}

public class Program
{
    public static void Main()
    {
        var partialClass = new MyClass();

        partialClass.Method1();
        partialClass.Method2();
    }
}