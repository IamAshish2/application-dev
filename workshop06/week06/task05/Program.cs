namespace task05;

public class Program
{
    public static void Main(string[] args)
    {
        var sales = new List<CashierSales>
        {
            new CashierSales { CashierName = "John", SalesAmount = 1200 },
            new CashierSales { CashierName = "Sara", SalesAmount = 1500 },
            new CashierSales { CashierName = "Mike", SalesAmount = 900 },
            new CashierSales { CashierName = "Anna", SalesAmount = 1800 }
        };

        int totalCashiers = sales.Count();

        double totalSales = sales.Sum(s => s.SalesAmount);

        double highestSales = sales.Max(s => s.SalesAmount);

        double lowestSales = sales.Min(s => s.SalesAmount);

        double averageSales = sales.Average(s => s.SalesAmount);

        Console.WriteLine($"Total Cashiers: {totalCashiers}");
        Console.WriteLine($"Total Sales: {totalSales}");
        Console.WriteLine($"Highest Sales: {highestSales}");
        Console.WriteLine($"Lowest Sales: {lowestSales}");
        Console.WriteLine($"Average Sales: {averageSales}");
        Console.WriteLine();

        var applicants = new List<Applicants>
        {
            new Applicants { ApplicantName = "Ram", Age = 19 },
            new Applicants { ApplicantName = "Sita", Age = 22 },
            new Applicants { ApplicantName = "Hari", Age = 17 },
            new Applicants { ApplicantName = "Gita", Age = 20 }
        };

        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine($"Any applicant under 18: {anyUnder18}");
        Console.WriteLine($"All applicants above 16: {allAbove16}");
        Console.WriteLine();

        var songs = new List<Music>
        {
            new Music { Title = "Song A", DurationInSeconds = 180 },
            new Music { Title = "Song B", DurationInSeconds = 250 },
            new Music { Title = "Song C", DurationInSeconds = 310 },
            new Music { Title = "Song D", DurationInSeconds = 6000 }
        };

        var firstSong = songs.First();
        var lastSong = songs.Last();
        var firstLongSong = songs.First(s => s.DurationInSeconds > 240);
        var songLongerThan10Min = songs.FirstOrDefault(s => s.DurationInSeconds > 600);

        Console.WriteLine($"First Song: {firstSong.Title}");
        Console.WriteLine($"Last Song: {lastSong.Title}");
        Console.WriteLine($"First Song Above 4 Minutes: {firstLongSong.Title}");
        Console.WriteLine($"Song Longer Than 10 Minutes: {songLongerThan10Min.Title}");
    }
}