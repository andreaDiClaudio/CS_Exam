public class Program
{
    //returning tuple
    public static (int, int) GetIntegral(int nominator, int denominator)
    {
        int whole = nominator / denominator;
        int part = nominator - (whole * denominator);
        return (whole, part);
    }

    //named tuple properties
    public static (int Whole, int Part) getNamedIntegral(int nominator, int denominator)
    {
        int w = nominator / denominator;
        int p = nominator - (w * denominator);
        return (Whole: w, Part: p);
    }

    public static void Main()
    {
        /*Tuples*/
        var t1 = new Tuple<string, int>("Andrea", 22);

        var t2 = Tuple.Create("Nicolas", 33);

        Console.WriteLine(t1.Item1 + " " + t1.Item2);
        Console.WriteLine(t2.Item2 + " " + t2.Item1);

        //Deconstruction
        //Example 1
        var t3 = Tuple.Create("Hello", "World");

        (string f, string d) = t3;

        Console.WriteLine(f + " " + d); // Output: Hello world

        //Example 2
        var t4 = (3, 4);
        Console.WriteLine($"{t4.Item1} and {t4.Item2}"); // Output: 3 and 4

        //Returning Tuples
        var t5 = GetIntegral(5, 10);

        Console.WriteLine($"{t5.Item1} and {t5.Item2}"); // Output: 0 and 5

        //Named tuple properties
        var t6 = getNamedIntegral(5, 4);
        Console.WriteLine($"{t6.Whole} and {t6.Part}"); // Output: 1 and 1
    }
}