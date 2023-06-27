using System.Runtime.InteropServices;

public class Program
{
    //Named parameters
    public static int AddNumber(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    //optional parameters - method overload
    public static int AddNumber(int number)
    {
        return AddNumber(number, 0);
    }

    //optional parameters - method params
    public static int AddNumber(params int[] numbers)
    {
        int result = 0;
        foreach (var num in numbers)
        {
            result += num;
        }

        return result;
    }

    //optional parameters - default assign
    public static int Numbers(int firstNumber, int secondNumber = 0)
    {
        return firstNumber + secondNumber;
    }

    //optional parameters - optional attribute
    public static int OptionalNumber(int firstNumber, [Optional] int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    public static void Main()
    {
        /*Parameters*/
        //Named parameters
        int x = AddNumber(firstNumber: 3, secondNumber: 4);
        int y = AddNumber(secondNumber: 6, firstNumber: 10);
    }
}