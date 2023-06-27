using System;
using System.Collections.Generic;

/*Generics*/
public class DataStore<T>
{
    private T[] data = new T[10];

    public T this[int index]
    {
        get => data[index];
        set => data[index] = value;
    }
}

public class Program
{

    public static void Main()
    {
        /*Generics*/
        var cities = new DataStore<string>();
        cities[0] = "Copenhagen";
        cities[1] = "Rome";

        var employeeId = new DataStore<int>();

        employeeId[0] = 12;
        employeeId[1] = 467;
        employeeId[2] = 12433434;

        //List Invariance
        List<string> stringList = new List<string>();
        //List<object> objectList = stringList; // This will result in a compile-time error

        //Array Covariance
        string[] stringArray = new string[] { "Hello", "World" };
        object[] objectArray = stringArray; // Covariant assignment

    }

}