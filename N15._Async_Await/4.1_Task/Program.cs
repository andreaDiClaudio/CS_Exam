using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        /*Task*/
        Task task1 = Task.Run(() => Console.WriteLine("Task 1 is running"));
        Task task2 = Task.Run(() => Console.WriteLine("Task 2 is running"));

        await Task.WhenAll(task1, task2);

        /*Task with result*/
        Task<int> task3 = Task.Run(() => 2 * 3);
        Task<int> task4 = Task.Run(() => 4 * 5);

        int result1 = await task3;
        int result2 = await task4;

        Console.WriteLine($"Result 1: {result1}");
        Console.WriteLine($"Result 2: {result2}");

        Task<int> task5 = Task.Run(() => 2 * 3);

        //Continuation
        Task<int> task6 = task5.ContinueWith(previousTask => previousTask.Result * 4);

        int result3 = await task6;

        Console.WriteLine($"Result: {result3}");
    }
}