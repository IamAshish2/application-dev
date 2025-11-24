namespace Task02;

public class Program
{
    public static void Main()
    {
        // Create Car object
        Car car = new Car
        {
            Brand = "Toyota",
            Speed = 180,
            Seats = 5
        };

        // Create Motorcycle object
        MotorCycle moto = new MotorCycle()
        {
            Brand = "Yamaha",
            Speed = 120,
            HasCarrier = true
        };

        // Demonstrating method reusability and overriding
        Console.WriteLine("=== Car Info ===");
        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine("\n=== Motorcycle Info ===");
        moto.Start();
        moto.DisplayInfo();
        moto.Stop();
    }
}