namespace Task02;

public class MotorCycle : Vehicle
{
    public bool HasCarrier { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Carrier: {HasCarrier}");
    }
}