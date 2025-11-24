namespace task05;

public class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine($"{device.Brand} added to store.");
    }

    public void RemoveDevice(ElectronicDevice device)
    {
        devices.Remove(device);
        Console.WriteLine($"{device.Brand} removed from store.");
    }

    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("\n--- Device Details ---");

        foreach (var device in devices)
        {
            // Call abstract method (runtime polymorphism)
            device.ShowInfo();

            // DOWNCAST to call child-specific methods
            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is SmartPhone phone)
            {
                phone.EnableCamera();
            }

            Console.WriteLine();
        }
    }
}