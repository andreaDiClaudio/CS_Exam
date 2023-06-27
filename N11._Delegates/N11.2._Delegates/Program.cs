/*Delegates*/
public class Program1
{
    //1. Declaration
    public delegate bool IntPredicate(int value);

    //2. Target method - matches the signature
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static void Main(string[] args)
    {
        //3. Instance - encapsulate method
        IntPredicate isEvenPredicate = IsEven;

        // Invoking
        bool isEven = isEvenPredicate(4); // Returns true
    }
}