namespace task03;

public class Program
{
    public static void Main(string[] args)
    {
        ParameterDemo pd  = new ParameterDemo();
        
        pd.GetFullName(out string fullName);
        Console.WriteLine($"The full name is {fullName}");

        int number = 44;
        pd.Increase(ref number);
        Console.WriteLine($"The number  increased by the increase method is {number}");

        int sum = pd.SumAll([1,2,3,4,5]);
        Console.WriteLine("The sum of all numbers is {0}", sum);
        
    }
}