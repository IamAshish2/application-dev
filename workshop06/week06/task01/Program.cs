namespace task01;

public class Program
{
    public static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        r.Breadth = 10;
        r.Length = 4;
        
        Console.WriteLine(r.ShowDetails());
        Console.WriteLine($"The area of the rectangle is {r.GetArea()}");
        Console.WriteLine($"The  perimeter of the rectangle is {r.GetPerimeter()}");
    }
}