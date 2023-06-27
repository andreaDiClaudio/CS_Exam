using System;
using System.Threading.Tasks;

/*Async/Await*/
class Program
{
    static async Task Task1()
    {
        Console.WriteLine("Starting task 1");
        await Task.Delay(1000);
        Console.WriteLine("finished task1");
    }
}