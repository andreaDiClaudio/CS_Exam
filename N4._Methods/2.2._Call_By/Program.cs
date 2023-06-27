public class Program
{
    //call-by value
    static void SquareVal(int valParameter)
    {
        valParameter *= valParameter;
        Console.WriteLine($"During method, number: {valParameter}"); // Output: 25
    }

    //call-by reference
    static void SquareRef(ref int refParameter)
    {
        refParameter *= refParameter;
    }

    public class Student
    {
        public bool IsEnrolled;
        public bool IsReEnrolled;
    };

    // Out
    public static void Enroll(out Student student)
    {
        student = new Student();
        student.IsReEnrolled = true;
    }

    //in
    public static void ReEnroll(in Student student)
    {
        // student = new Student() -> Will throw an error

        student.IsEnrolled = false;
    }

    public static void Main()
    {
        /*Call-by*/
        //Call-by Value
        int number = 5;
        Console.WriteLine("Before method call, number: " + number); // Output: 5

        SquareVal(number);
        Console.WriteLine("After method call, number: " + number); // Output: 5

        //Call-by reference
        int number2 = 5;
        Console.WriteLine("Before method call, number: " + number2); // Output: 5

        //ref - may
        SquareRef(ref number2);
        Console.WriteLine("After method call, number: " + number2); // Output: 25

        //out - must
        Student student;
        Enroll(out student);

        //in - cannot
        ReEnroll(in student);

    }
}