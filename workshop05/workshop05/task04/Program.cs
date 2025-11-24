namespace task04;

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        Bike bike = new Bike();

        Console.WriteLine("=== Car Actions ===");
        car.Display();
        car.StartEngine();
        car.StopEngine();

        Console.WriteLine("\n=== Bike Actions ===");
        bike.Display();
        bike.StartEngine();
        bike.StopEngine();
    }
}