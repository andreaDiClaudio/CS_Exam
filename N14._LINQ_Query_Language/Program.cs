using System;
using System.Collections.Generic;
using System.Linq;

/*LINQ*/
public class Program
{

    class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    public static void Main(string[] args)
    {
        List<string> animalNames = new List<string> { "fawns", "gibbon", "heron", "ibex" };

        //Query syntax
        IEnumerable<string> longAnimalNames =
            //from syntax
            from name in animalNames
                //where syntax
            where name.Length >= 5
            //orderby syntax
            orderby name.Length
            //select syntax
            select name;

        //Usage on object
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 15 },
            new Person { Name = "Charlie", Age = 35 },
            new Person { Name = "David", Age = 28 }
        };

        var adults = from p in people
                     where p.Age >= 18
                     orderby p.Name
                     select p.Name;

        foreach (string name in adults)
        {
            Console.WriteLine(name);
        }
    }
}