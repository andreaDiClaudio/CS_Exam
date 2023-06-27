public class Program
{
    /*Nested*/
    /*Class - A class is a reference type that can be used to define an object. */
    public class Person
    {
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        protected int age;
        private string phone;
        internal string Email;
        protected internal int workerId;
        private protected string address;
        public void SetAddress(string value)
        {
            address = value;
        }

        public string GetAddress()
        {
            return address;
        }

        public const double Pi = 3.14159;

        //constructor
        public Person(string name, string email, int worker_Id)
        {
            Name = name;
            email = Email;
            worker_Id = workerId;
        }

        public Person()
        {
        }

        //this syntax
        //public Person(string name, string email) : this(name, email);
    }

    /*Struct is a value type that can be used to define simple data structures*/
    struct Coordinate
    {
        public int x;
        public int y;
    }

    /*Record immutable reference types*/
    record Animal(string Name, int age);

    public static void Main()
    {
        //Object initializer
        var person1 = new Person()
        {
            Name = "Andrea",
            Email = "email",
            workerId = 2,
        };

        person1.SetAddress("Copenhagen Vej");

        /*Struct - value type*/
        Coordinate pointA = new Coordinate();
        Coordinate pointB = pointA;

        /*Record*/
        Animal dog = new("doogo", 3);
        Animal dog2 = dog with { Name = "Doggo2" };
    }
}