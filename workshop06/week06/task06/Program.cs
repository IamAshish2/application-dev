namespace task06;

public class Program
{
    public static void Main(string[] args)
    {
        var bookings = new List<TourBooking>
        {
            new TourBooking
            {
                CustomerName = "Alice", Destination = "Paris", Price = 15000, DurationInDays = 7, IsInternational = true
            },
            new TourBooking
            {
                CustomerName = "Bob", Destination = "Kathmandu", Price = 8000, DurationInDays = 3,
                IsInternational = false
            },
            new TourBooking
            {
                CustomerName = "Charlie", Destination = "London", Price = 12000, DurationInDays = 5,
                IsInternational = true
            },
            new TourBooking
            {
                CustomerName = "Diana", Destination = "Pokhara", Price = 6000, DurationInDays = 2,
                IsInternational = false
            },
            new TourBooking
            {
                CustomerName = "Ethan", Destination = "Tokyo", Price = 18000, DurationInDays = 6, IsInternational = true
            }
        };


        var expensiveTours = bookings.Where(b => b.Price > 10000);
        var longTours = bookings.Where(b => b.DurationInDays > 4);
        var filteredTours = bookings
            .Where(b => b.Price > 10000 && b.DurationInDays > 4);


        Console.WriteLine("Tours above Rs. 10,000:");
        foreach (var tour in expensiveTours)
        {
            Console.WriteLine($"{tour.CustomerName} - {tour.Destination} - Rs.{tour.Price}");
        }

        Console.WriteLine("\nTours longer than 4 days:");
        foreach (var tour in longTours)
        {
            Console.WriteLine($"{tour.CustomerName} - {tour.Destination} - {tour.DurationInDays} days");
        }

        Console.WriteLine("\nTours above Rs. 10,000 AND longer than 4 days:");
        foreach (var tour in filteredTours)
        {
            Console.WriteLine(
                $"{tour.CustomerName} - {tour.Destination} - Rs.{tour.Price} - {tour.DurationInDays} days");
        }

        var projectedList = filteredTours
            .Select(b => new
            {
                CustomName = b.CustomerName,
                b.Destination,
                b.Price,
                Category = b.IsInternational ? "International" : "Domestic"
            })
            .OrderBy(b => b.Category)
            .ThenBy(b => b.Price)
            .ToList();


        Console.WriteLine("Filtered, Categorized, and Sorted Tours:\n");

        foreach (var tour in projectedList)
        {
            Console.WriteLine($"Customer: {tour.CustomName}");
            Console.WriteLine($"Destination: {tour.Destination}");
            Console.WriteLine($"Category: {tour.Category}");
            Console.WriteLine($"Price: Rs.{tour.Price}");
            Console.WriteLine();
        }
    }
}