namespace task03;

public class Program
{
    public static void Main(string[] args)
    {
        Func<int, bool> evenNumbers = n => n % 2 == 0;
        Func<int, bool> numbersGreaterThan10 = n => n > 10;

        int[] numbers = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14};
        Console.Write("The even numbers are: ");
        ProcessNumbers(numbers, evenNumbers);
        Console.Write("The numbers greater than 10 are: ");
        ProcessNumbers(numbers, numbersGreaterThan10);
        
    }

    public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (var number in numbers)
        {
            if (condition(number))
            {
                Console.Write($"{number} ");
            }
        }
        Console.WriteLine();
    }

}