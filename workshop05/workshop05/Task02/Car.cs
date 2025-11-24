namespace Task02;

public class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        // Call base class method (optional but shows reuse)
        base.DisplayInfo();
        Console.WriteLine($"Seats: {Seats}");
    }
}