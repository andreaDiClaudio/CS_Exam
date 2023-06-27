using System;
using System.Collections.Generic;
public class Program
{
    public static void updateNums(int[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            list[i] += 10;
            Console.WriteLine(list[i]);
        }
    }

    public static void Main()
    {
        /*Array*/
        //declare with size
        int[] numbers1 = new int[5];

        //initialise with size
        var numbers2 = new int[3] { 1, 2, 4 };

        //initialise without new keyword
        int[] numbers3 = { 4, 5, 6 };

        /*Accessing Arrays*/
        //square brackets
        Console.WriteLine(numbers2[2]);

        //for loop
        for (int i = 0; i < numbers2.Length; i++)
        {
            Console.WriteLine(numbers2[i]);
        }

        //foreach loop
        foreach (int number in numbers3)
        {
            Console.WriteLine(number);
        }

        /*Array inheritance*/
        //Implemente IEnumerable interface
        numbers1.Max(); //returns the biggest
        numbers2.Min(); //return the smallest
        numbers3.Average(); //returns average
        numbers3.Sum(); //returns sum

        //Reference type
        int[] sums = { 10, 34, 56, 76 };
        updateNums(sums);
        foreach (int number in sums)
        {
            Console.WriteLine("sums list: " + number); // values are changed 
        }

        /*Multidimensional Array*/
        // jagged array
        int[][] jaggedArray = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 6, 7, 8, 9 }
        };
        Console.WriteLine(jaggedArray[0][2]);

        object[][] objectJaggedArray = new object[][]
        {
            new object[] {"A", "B", "C"},
            new object[] { 1, 2, 4, 5 }
        };

        for (int i = 0; i < objectJaggedArray.Length; i++)
        {
            for (int j = 0; j < objectJaggedArray[i].Length; j++)
            {
                Console.WriteLine("-------------");
                Console.WriteLine(objectJaggedArray[i][j]);
            }
        }

        //multidimensional array
        int[,] multidimensionalArray = new int[,]
        {
            {1,2,3},
            {456,4,3} //Error
        };
        Console.WriteLine(multidimensionalArray[0, 1]);

        /*Indexes*/
        Index firstPostion = new Index(value: 0);
        Console.WriteLine(numbers2[firstPostion]);

        Index lastPostion = new Index(1, fromEnd: true);
        Console.WriteLine(numbers2[lastPostion]);

        Index lastPosition1 = ^1;
        Console.WriteLine(numbers2[lastPosition1]);

        /*Ranges - Ranges allow you to create a new subarray by specifying a range of indices*/
        var numbersList = new int[] { 2, 4, 78, 3, 2, 6, 7, 432, 25, 6 };
        // The original array remains unchanged.
        int[] rangedArray = numbersList[4..6];

        for (int i = 0; i < rangedArray.Length; i++)
        {
            Console.WriteLine(rangedArray[i]); // Output: 2, 6
        }

        /*Span - llows you to create a "view" or "slice" of the original array without creating a new array*/
        Span<int> subArray = numbersList.AsSpan(1, 3);


        /*Collections*/
        var ages = new Dictionary<string, int>
        {
            { "Alice", 30 },
            { "Bob", 25 },
            { "Charlie", 35 }
        };

        Console.WriteLine("Alice's age: " + ages["Alice"]);

        //Stack
        var stack = new Stack<int>();

        stack.Push(1);
        stack.Push(20);
        stack.Push(23);

        int topElement = stack.Peek();
        Console.WriteLine(topElement); // output: 23

        int popped = stack.Pop();
        Console.WriteLine(popped); // output: 23

        //Queue
        var queue = new Queue<int>();

        queue.Enqueue(20);
        queue.Enqueue(50);

        int dequeued = queue.Dequeue();
        Console.WriteLine(dequeued); // output: 20
    }

}