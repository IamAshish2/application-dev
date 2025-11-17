namespace task02;

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        calc.PrintWelcome();
        int add = calc.Add(4, 4);
        Console.WriteLine($"The addition result is {add}.");

        int multiply = calc.Multiply(3, 3);
        Console.WriteLine($"The multiplication result is {multiply}.");

        int multiplyRes = calc.Multiply(3);
        Console.WriteLine($"The multiplication result with only the required parameter is {multiplyRes}.");
    }
}