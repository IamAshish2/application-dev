namespace task06;

public class Program
{
    public static void Main(string[] args)
    {
        int marks;
        Console.Write("Enter your of marks: ");
        int.TryParse(Console.ReadLine(), out marks);

        int total;
        Console.WriteLine("Enter your total: ");
        int.TryParse(Console.ReadLine(), out total);

        int percentage = (marks / total) * 100;
        Console.WriteLine($"The total percentage is {percentage}.");
    }
}