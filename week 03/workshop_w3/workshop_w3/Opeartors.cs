namespace workshop_w3;

public class Opeartors
{
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }


    public void Subtract(int a, int b)
    {
        Console.WriteLine(a - b);
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine(a * b);
    }

    public void Divide(int a, int b)
    {
        Console.WriteLine(a / b);
    }

    public void OddEvenFinder(int number)
    {
        Console.WriteLine((number % 2 == 0) ? "Even Number" : "Odd Number");
    }
}