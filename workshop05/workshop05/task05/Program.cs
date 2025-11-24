namespace task05;

public class Program
{
    public static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        Laptop laptop = new Laptop("Dell", 1200);
        SmartPhone phone = new SmartPhone("Samsung", 900);

        store.AddDevice(laptop);
        store.AddDevice(phone);

        store.ShowAllDeviceDetails();
    }
}