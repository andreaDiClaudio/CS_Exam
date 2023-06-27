public class Program
{
    public static void Main()
    {
        /*Pattern Matching*/
        //switch expression
        object value1 = 42;

        var result = value1 switch
        {
            int i when i > 0 => "positive integer", //type pattern - match type
            string str => $"String with length {str.Length}", //type pattern
            null => "null value", //type pattern
            _ => "Unkown type" //discard pattern
        };

        //is expression
        object value2 = "Hello World";

        if (value2 is string s) //declaration pattern - assign value to a new varibale
        {
            Console.WriteLine($"Value is a string with length {s.Length}");
        }

        //switch statement with pattern cases
        object value3 = 3.14;

        switch (value3)
        {
            case int i:
                Console.WriteLine("Value is an int");
                break;
            case double d:
                Console.WriteLine("Value is a double");
                break;
            default:
                Console.WriteLine("Value is unkown");
                break;
        }

        //constant pattern - if value equal to specific value
        int number = 5;

        var result1 = number switch
        {
            0 => "Zero",
            1 => "One",
            _ => "Else"
        };

        //Relational Pattern - comparative operators
        int number2 = 33;
        var result2 = number2 switch
        {
            < 0 => "negative",
            > 0 => "Postive",
        };

        //logical pattern - use of logical operator
        int number3 = 46;
        var result3 = number3 switch
        {
            > 0 and < 10 => "Between zero and ten",
            _ => "other"
        };

        //var pattern - to match any non-null value and assign them to a new variable
        object value5 = 42;

        var result5 = value5 switch
        {
            null => "Null value",
            var x => $"Value is of type {x.GetType()}"
        };
        Console.WriteLine(result5); // Output: Value is of type System.Int32

    }
}