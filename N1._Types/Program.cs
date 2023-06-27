using System;

public interface IForm { }

public class MainForm : IForm { }

public class Person
{
    public string Name;
}
public class Program
{
    public static void Main()
    {
        /*Implicit typed local variable*/
        //normal declaration
        List<int> list = new List<int>();

        //Implicit typed 
        var list1 = new List<int>();
        /*--------------------------------*/

        object c = new MainForm();

        /*Type checking*/
        // Do they match the exact type?
        if (c.GetType() == typeof(MainForm))
        {
            Console.WriteLine("c is MainForm"); // Output: "c is MainForm"
        }

        // Are they equal or derived?
        if (c is IForm)
        {
            Console.WriteLine("c is IForm"); // Output: "c is IForm"
        }

        /*Operator Overload*/
        //syntax - public static <className> operator <operatorSymbol>(<parameters>) {<code>}

        /*String Interpolation*/
        string author = "Andrea";
        string greet = $"Hello {author}";
        Console.WriteLine(greet); // Output: Hello Andrea

        //allignment
        int price1 = 22;
        int price2 = 44;

        Console.WriteLine($"Right aligned {price1,13}");
        Console.WriteLine($"Left aligned {price2,-13}");

        //Expression
        Console.WriteLine($"3 + 2 = {3 + 2}"); // Output: 3 + 2 = 5

        //Raw String
        var title = """
        <h1>Title<h1>
        """;

        //Verbatim
        string verbatimString = @"This is a verbatim
        string that spans
        multiple lines.";

        string verbatimString2 = @"This is a verbatim string with escape characters: \t \n and ""quotes"".";
    }
}