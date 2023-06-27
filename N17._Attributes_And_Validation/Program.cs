using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;

public class Program
{
    /*Attributes*/
    public class Animal
    {
        [Required]
        public string Name { get; set; }

        [Range(0, 15)]
        public int Age { get; set; }

    }

    /*Attributes*/
    [Obsolete("This method is deprecated. Use NewMethod instead")]
    public void oldMethod()
    {
        //code
    }


    /*Data Validation*/
    public static bool Validate(Animal animal)
    {
        var results = new List<ValidationResult>();
        var context = new ValidationContext(animal);

        return Validator.TryValidateObject(animal, context, results, true);
    }


    public static void Main()
    {
        /*Data Validation*/
        var dog = new Animal() { Name = "doggo", Age = 3 };

        bool isValidated = Validate(dog);
        Console.WriteLine("The result is: " + isValidated); // output: the result is true

    }


    /*Custom Attributes*/
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class DisplayNameAttribute : Attribute
    {
        public string DisplayName { get; set; }

        public DisplayNameAttribute(string displayName)
        {
            DisplayName = displayName;
        }
    }

    public class Calculator
    {
        [DisplayName("Addition")]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [DisplayName("Subtraction")]
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}