using System;

public static class StringExtensions
{
    // This keyword indicates the exstension
    public static string Reverse(this string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string original = "Hello, world!";
        string reversed = original.Reverse();

        Console.WriteLine("Original: " + original);
        Console.WriteLine("Reversed: " + reversed);
    }
}