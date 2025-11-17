namespace task01;

public class Program
{
    public static void Main(string[] args)
    {
        Student st1 = new Student();
        Student st2 = new Student();

        st1.studentName = "Ashish Karki";
        st1.age = 20;
        st1.section = "L3C7";
        Console.WriteLine($"Printing student one's details");
        Console.WriteLine(st1.studentName);
        Console.WriteLine(st1.age);
        Console.WriteLine(st1.section);


        st2.studentName = "Salon Khulal";
        st2.age = 22;
        st2.section = "L3C7";
        Console.WriteLine($"Printing student two's details");
        Console.WriteLine(st2.studentName);
        Console.WriteLine(st2.age);
        Console.WriteLine(st2.section);

        Console.WriteLine();
        Console.WriteLine($"Printing the static field: ");
        Console.WriteLine(Student.phoneNumber);
    }
}