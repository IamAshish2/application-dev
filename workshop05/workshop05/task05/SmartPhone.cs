namespace task05;

public class SmartPhone: ElectronicDevice
{
    public SmartPhone(string brand, double price) : base(brand, price)
    {
    }

    public void EnableCamera()
    {
        Console.WriteLine($"{Brand} smartphone camera enabled.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Smartphone Brand: {Brand}, Price: {Price}");
    }
}