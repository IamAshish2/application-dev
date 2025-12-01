namespace task02;
public class Program
{
    public static void Main(string[] args)
    {
        double originalPrice = 40d;

        Delegates.Calculate calc;
        calc = Add;
        Console.WriteLine($"The result of addition is {calc(10,10)}");

        calc = Subtract;
        Console.WriteLine($"The result of subtraction is {calc(10,10)}");

        Delegates.DiscountStrategy strategy;

        strategy = FestivalDiscount;
        Console.WriteLine($"Festival discount price: {strategy(originalPrice)}");
        Console.WriteLine($"Final price after festival discount: {CalculateFinalPrice(originalPrice, FestivalDiscount)}");

        strategy = SeasonalDiscount;
        Console.WriteLine($"Seasonal discount price: {strategy(originalPrice)}");
        Console.WriteLine($"Final price after seasonal discount: {CalculateFinalPrice(originalPrice, SeasonalDiscount)}");

        strategy = NoDiscount;
        Console.WriteLine($"No discount price: {strategy(originalPrice)}");
        Console.WriteLine($"Final price after no discount: {CalculateFinalPrice(originalPrice, NoDiscount)}");

        Console.WriteLine($"Final price with guaranteed discount: {CalculateFinalPrice(originalPrice, price => price - (0.3 * price))}");
    }

    private static int Add(int a, int b) => a + b;
    private static int Subtract(int a, int b) => a - b;

    private static double FestivalDiscount(double price) => price - (0.2 * price);
    private static double SeasonalDiscount(double price) => price - (0.1 * price);
    private static double NoDiscount(double price) => price;

    private static double CalculateFinalPrice(double originalPrice, Delegates.DiscountStrategy strategy)
    {
        return strategy(originalPrice); 
    }
}