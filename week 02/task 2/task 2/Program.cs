public class Circle
{
    const double PI = 3.14f;
    public static void Main(string[] args)
    {
        // PI = 5
        // the constant value of PI cannot be reiniatilized because it is of immutable type
        Console.Write("Please enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(CalculateArea(radius));
        Console.WriteLine(CalculatePerimeter(radius));
    }

    private static double CalculateArea(double radius)
    {
        return PI * (radius * radius);
    }

    private static double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}