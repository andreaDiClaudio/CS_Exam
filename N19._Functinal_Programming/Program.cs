﻿//Functional Programming
public class Program
{
    public static void Main()
    {
        //Immutable Types - remain unchanged
        string greeting = "Hello";
        string updatedGreeting = greeting.ToUpper();

        //Expressions instead of statements
        int a = 5;
        int b = 6;
        int max = a > b ? a : b;

        //Higher-order functions
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var squaredNumbers = numbers.Select(x => x * x); //as parameter

        //Functional composition
        Func<int, int> timesTwo = x => x * 2;
        Func<int, int> plusThree = x => x + 3;
        Func<int, int> timesTwoPlusThree = x => plusThree(timesTwo(x));

        //Method chaining
        var evenSquares = numbers.Where(x => x % 2 == 0).Select(x => x * x);
    }

    //Pattern matching
    public static string GetShapeType(object shape) => shape switch
    {
        Circle c => "Circle",
        Rectangle r => "Rectangle",
        _ => "Unknown"
    };

    //Lazy evaluation
    public static IEnumerable<int> GetSquares(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            yield return i * i;
        }
    }
}