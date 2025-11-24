namespace task03;

public class Program
{
    public static void Main(string[] args)
    {
        NepaliTeacher nepaliTeacher = new NepaliTeacher();
        nepaliTeacher.Name = "Mr. Ram";
        Console.WriteLine($"Teacher Name: {nepaliTeacher.Name}");
        nepaliTeacher.Teaching();     // Overridden method
        nepaliTeacher.SalaryInfo();   // Sealed method

        Console.WriteLine();

        EnglishTeacher englishTeacher = new EnglishTeacher();
        englishTeacher.Name = "Mrs. Smith";
        Console.WriteLine($"Teacher Name: {englishTeacher.Name}");
        englishTeacher.Teaching();    // Uses base class method
        englishTeacher.SalaryInfo();  // Sealed method
    }
}