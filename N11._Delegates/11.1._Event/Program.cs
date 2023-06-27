/*Event*/
using System;

public class Observer
{
    public delegate void NotifyEventHandler(string message);

    public event NotifyEventHandler Notify;

    public void Publish(string message)
    {
        if (Notify != null)
        {
            Notify(message);
        }
    }
}


public class Subscriber
{
    private readonly string _name;

    public Subscriber(string name)
    {
        _name = name;
    }

    //event handler that gets called when the Publish method of the Observer is called.
    public void OnNotify(string message)
    {
        Console.WriteLine($"Subscriber {_name} received: {message}");
    }
}

public class Program
{
    public static void Main()
    {
        Observer observer = new Observer();

        Subscriber subscriber1 = new Subscriber("A");
        Subscriber subscriber2 = new Subscriber("B");

        //subscribe their respective OnNotify methods to the Notify event.
        observer.Notify += subscriber1.OnNotify;
        observer.Notify += subscriber2.OnNotify;

        //When the observer publishes the message, both subscribers receive the message and process it in their OnNotify method.
        observer.Publish("Hello, Observer pattern!");

        observer.Notify -= subscriber1.OnNotify; // Unsubscribe
        observer.Publish("Only Subscriber B is listening.");
    }
}