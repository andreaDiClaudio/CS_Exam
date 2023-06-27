public class Program
{
    public static void Main()
    {
        //Exstension Method
        List<String> fruits = new() { "apple", "banana", "orange", "passionfruit" };

        //Single Value expression
        int numberOfFruits = fruits.Count();

        //Return a single element
        var first = fruits.First();

        var last = fruits.Last();

        var single = fruits.Single(x => x == "apple");

        //Return multiple elements
        var takenFruit = fruits.Take(2); // output: appple, banana

        var skip = fruits.Skip(2); // Output: orange, passionfruit

        var takeLast = fruits.TakeLast(2);

        var skipLast = fruits.SkipLast(2);

        var takeWhile = fruits.TakeWhile(x => x.Length <= 3);

        var skipWhile = fruits.SkipWhile(x => x.Length == 5); // output all of them beside apple

        //Return a different sequence
        var numbers = new List<int>() { 1, 2, 3, 4, 5, 4, 5, 8 };

        var where = numbers.Where(n => n > 3);

        var distinct = numbers.Distinct();

        /*Grouping and query syntax*/
        var mapped = fruits.Select(e => e.Length);
    }
}