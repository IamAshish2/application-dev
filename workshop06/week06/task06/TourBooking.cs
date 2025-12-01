namespace task06;

public class TourBooking
{
    public string CustomerName { get; set; } = null!;
    public string Destination { get; set; } = null!;
    public double Price { get; set; }
    public int DurationInDays { get; set; }
    public bool IsInternational { get; set; }
}
