public class Program
{
    public static void Main()
    {
        // A lambda expression with one parameter and a single expression
        var plusFive = (int num) => num + 5;

        // A lambda expression with two parameters and a single expression
        var add = (int x, int y) =>
        {
            return x + y;
        };
        Console.WriteLine(add(2, 5));

        // A lambda expression with a statement block
        var greet = (string name) =>
        {
            return $"Hello {name}";
        };
        Console.WriteLine(greet("Andrea"));

        //Lambdas with Linq
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        // Filter the numbers to get only the even numbers
        var evenNumbers = numbers.Where(x => x % 2 == 0);
        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }

        // Calculate the square of each number
        var squaredNumbers = numbers.Select(x => x * x);
        foreach (int number in squaredNumbers)
        {
            Console.WriteLine(number);
        }

        // Calculate the sum of all numbers
        int sum = numbers.Aggregate((x, y) => x + y);
        Console.WriteLine(sum);

        // A lambda expression that does not return a value (Action)
        Action<string> display = message => Console.WriteLine(message);
        display("Hello, world!");

    }
}