namespace Task02;

public class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public void Start()
    {
        Console.WriteLine($"{Brand} has started.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Brand} has stopped.");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}