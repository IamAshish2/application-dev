namespace task04;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = [1, 2, 3, 4, 5];
        List<int> squaredNumbers = (from number in numbers select number * number).ToList();
        Console.WriteLine("The squared numbers are:");
        foreach (var number in squaredNumbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
        
        
        Console.WriteLine();
        Console.Write("Filtering using (Where)");
        List<int> bookPrices = [1000,1100,120,100,600,4000,5000];
        List<int> premiumPrices = (from price in bookPrices where price > 1000 select price).ToList();
        Console.Write("The premium prices filtered are: ");
        foreach (var price in premiumPrices)
        {
            Console.Write($"{price} ");
        }
        Console.WriteLine();
        
        List<string> scholarShipStudents = ["Ashish Karki","Salon Khulal","Anjal Khadka","Premdeep Rai","Saurab Basnet","Bardan G. Neupane"];
        List<string> ascendingScholars = scholarShipStudents.OrderBy(s =>  s).ToList();
        
        Console.WriteLine();
        Console.WriteLine("The ascending scholars are: ");
        foreach (var ascending in ascendingScholars)
        {
         Console.WriteLine($"{ascending }");   
        }
        Console.WriteLine();
        
        List<string> descendingScholars = scholarShipStudents.OrderByDescending(s =>  s).ToList();
        Console.WriteLine("The descending scholars are: ");
        foreach (var descending in descendingScholars)
        {
            Console.WriteLine($"{descending }");   
        }
    }
}